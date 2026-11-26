# HANOUTY POS V2.0 — سجل تغييرات الحزمة WP1

**المرجع الأساسي:** `origin/integration/hanouty-qa-desktop-inventory-20261102` (`18648f4f`)  
**فرع التطوير:** `feat/wp1-stabilization-solution-20261124`  
**التاريخ:** 2026-11-24

## 1. الإصلاحات المنقولة انتقائياً من الفروع غير المدمجة
- **دمج كامل/نظيف من `origin/architecture/cell01-cashbox-lifecycle-20261117` (`ff00b29c`):**
  - إضافة `modernization/architecture/CashboxLifecycle.cs`
  - إضافة `modernization/architecture/CashboxJournalReplay.cs`
  - إضافة `modernization/architecture/CashboxLifecycle.Tests/` و`.github/workflows/cell01-cashbox-windows.yml`
- **نقل انتقائي من `origin/feature/hanouty-04-customer-account` (`8ae5272e`):**
  - إضافة التحقق من اكتمال بيانات الزبون (`CustomerId` و`Customer`) في `modernization/Hanouty.Desktop.Wpf/CustomerSettlementDialog.cs` مع الحفاظ على لوحة الأرقام والأزرار النقدية الأحدث في `18648f4f`.
  - إضافة اختبار وحدة في `modernization/Hanouty.Desktop.Wpf.Tests/Program.cs` للتحقق من رفض الزبون غير المكتمل.
- **نقل انتقائي من `origin/rescue/cell06-financial-host-guard-20261106` (`30327862`):**
  - حماية `diagnostic?.Invoke(ex)` داخل `CatalogueHost.Financial.cs` (`AcknowledgementFaultPort.Commit`) بحيث لا يُطمس استثناء الترحيل المالي الأصلي عند فشل المراقب التشخيصي.
- **فروع تم تجاوزها بعد التحقق من التكرار أو الاستبدال:**
  - `origin/fix/cashier-real-basket-display` (`aafec8b2`): وظيفته موجودة بالفعل ومطورة بشكل أحدث في `MainWindow.xaml` (`CashierBasket` مرتبط بـ `BasketLines`).
  - `origin/feature/hanouty-02-return-identity-20261117` (`d040c511`): التغييرات الأساسية في `MariaDbCashCheckoutServices.cs` وجداول الترجيع موجودة مسبقاً في `18648f4f`.

## 2. توحيد البناء والتبعيات وإنشاء Solution موحدة
- **إنشاء `Hanouty.sln`** في جذر المستودع لتجميع 34 مشروعاً (`modernization/`, `licensing/`, `business/`, `qa/`).
- **توحيد حزمة `MySql.Data` إلى الإصدار `9.5.0`** عبر 7 مشاريع في `modernization/inventory/` و`modernization/receipt-printing-acceptance/` لإزالة تضارب الإصدارات مع `CheckoutMariaDbProduction` (`9.4.0` ← `9.5.0`).
- **تعدد أهداف الإطار لمشاريع الترخيص (`licensing/*.csproj`):** تحديث `<TargetFrameworks>net8.0;net10.0</TargetFrameworks>` للحفاظ على توافق مسار `.NET 8` الحالي مع إتاحة الربط المباشر مع مشاريع `.NET 10` في الحزم القادمة.

## 3. فصل اختبارات القبول عن كود الإنتاج
- **إنشاء مشروع مستقل:** `modernization/Hanouty.Desktop.Acceptance/Hanouty.Desktop.Acceptance.csproj` و`Program.cs` لتشغيل اختبارات القبول (`Disposable*Acceptance.cs`).
- **تحديث `Hanouty.Desktop.Bootstrap.csproj` و`Program.cs`:** استبعاد ملفات `Disposable*Acceptance.cs` افتراضياً من بناء الإنتاج (`IncludeAcceptanceTests != 'true'`) مع إبقاء إمكانية تفعيلها عند الحاجة لسكربتات القبول عبر `-p:IncludeAcceptanceTests=true`.

## 4. حالة الاختبارات (ما تعذّر تشغيله في بيئة Linux الحالية)
بسبب عدم توفر نظام Windows أو `.NET 10 SDK` أو خادم MariaDB في بيئة التنفيذ الحالية (Linux)، **لم يتم تشغيل الاختبارات التالية فعلياً ويجب تشغيلها على Windows قبل اعتماد التسليم:**
- `Hanouty.Desktop.Wpf.Tests` (بما فيها اختبار حارس `CustomerSettlementDialog` المضاف).
- `CashboxLifecycle.Tests`.
- `Hanouty.Desktop.Acceptance` / `DisposableCashSaleAcceptance`.
- `Hanouty.Licensing.Smoke` و`Hanouty.Inventory.MariaDb.Tests` و`Hanouty.W1.RealMariaDb`.
