# سجل التقدم التنفيذي — HANOUTY POS V2.0 (WP1 → WP6)

**المرجع الأساسي:** `origin/integration/hanouty-qa-desktop-inventory-20261102` (`18648f4f`)  
**الفرع النشط:** `feat/wp1-stabilization-solution-20261124`

## الحزم المنجزة بالكود المصدري

### WP1 — تثبيت المستودع وتوحيد البناء وفصل اختبارات القبول
- إنشاء `Hanouty.sln` (34 مشروعاً).
- توحيد `MySql.Data` إلى `9.5.0` عبر مشاريع `modernization/` و`inventory/` و`receipt-printing-acceptance/`.
- تحديث `licensing/*.csproj` إلى `<TargetFrameworks>net8.0;net10.0</TargetFrameworks>`.
- فصل اختبارات القبول في `modernization/Hanouty.Desktop.Acceptance/` واستبعاد `Disposable*Acceptance.cs` افتراضياً من بناء الإنتاج في `Hanouty.Desktop.Bootstrap.csproj` مع دعم `-IncludeAcceptanceTests` في `scripts/Package-HanoutyWpf.ps1` و`.github/workflows/qa-w2-cash-sale.yml`.
- نقل الإصلاحات المتحققة من الفروع (`CustomerSettlementDialog` guard، `CatalogueHost.Financial.cs` diagnostic guard، و`CashboxLifecycle`).
- إنشاء مسار `.github/workflows/wp-stabilization-windows.yml`.

### WP2 — التحصين المالي التدريجي وفصل MVVM
- ربط `CashboxLifecycle.cs` و`CashboxJournalReplay.cs` بمشروع `Hanouty.ArchitectureBridge.csproj`.
- استخراج `ICashierDialogService` في `Hanouty.Desktop.Wpf/Presentation/ICashierDialogService.cs` وربطه في `MainWindow.xaml.cs` مع الحفاظ على السلوك الافتراضي دون تغيير وإضافة اختبار وحدة في `Hanouty.Desktop.Wpf.Tests/Program.cs`.
- الحفاظ على مستويات العزل المالية الحالية دون تعميم `IsolationLevel.Serializable` على عمليات القراءة.

### WP3 — المستخدمون ومصفوفة الصلاحيات
- إنشاء `UserRoleMatrix.cs` (`ADMIN` / `MANAGER` / `UTILISATEUR`) في `Hanouty.ArchitectureBridge` مع اختبارات وحدة في `Hanouty.ArchitectureBridge.Tests/Program.cs`.
- إنشاء `MariaDbUserStore.cs` (CRUD معزول بمعاملات على `TABLE_PASS` وحماية آخر `ADMIN`).
- إنشاء `UserManagementDialog.cs` في `Hanouty.Desktop.Wpf`.

### WP4 — المشتريات والتنبيهات والإحصائيات والملصقات
- إنشاء `PurchaseOrderStore.cs` و`PurchaseOrderDialog.cs` (`TABLE_COMMANDES_ENTETE` / `DETAILS` / `TABLE_NUM.BC`).
- إنشاء `StockAlertsReader.cs` و`StockAlertsDialog.cs` (تنبيهات المخزون السالب وتواريخ الصلاحية من `TABLE_RECEPTIONS_DETAILS`).
- إنشاء `SalesStatisticsReader.cs` و`SalesStatisticsDialog.cs` (المبيعات والهوامش من `TABLE_VENTES_JOURNAL`).
- إنشاء `BarcodeLabelDialog.cs` لمعاينة وطباعة ملصقات الباركود.

### WP5 — الترخيص المحلي، النسخ الاحتياطي، والمثبت المستقل
- ربط `Hanouty.Licensing.Core.csproj` بمشروع `Hanouty.Desktop.Bootstrap.csproj` وإنشاء `HanoutyLicenseStartupGate.cs`.
- إنشاء `DatabaseBackupRestoreService.cs` (مع تحقق SHA-256 ولقطة أمان قبل الاسترجاع) و`BackupRestoreDialog.cs`.
- إنشاء `scripts/Hanouty-Installer.iss` لبناء مثبت Windows مستقل عبر Inno Setup 6.

### WP6 — الاختبارات المضافة والعوائق الموثقة
- إضافة اختبارات `UserRoleMatrix` في `Hanouty.ArchitectureBridge.Tests/Program.cs` واختبارات `CustomerSettlementDialog` و`ICashierDialogService` في `Hanouty.Desktop.Wpf.Tests/Program.cs`.
- **العوائق المسجلة في بيئة Linux الحالية:**
  1. غياب `.NET 10 SDK` وWindows WPF وMariaDB حال دون البناء والتشغيل الفعلي للاختبارات (مؤجلة للتنفيذ على Windows أو عبر `.github/workflows/wp-stabilization-windows.yml`).
  2. عدم توفر وثيقة `Cahier des Charges LOGICA POS 2.0 V1.0` محلياً لحسم التفاصيل الشكلية الثانوية؛ تم الاعتماد على `recovered-source/LOGICA/` كمرجع schema ووظائف.
