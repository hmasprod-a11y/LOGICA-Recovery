# دليل البناء والتشغيل والاختبار على Windows — HANOUTY POS V2.0 (WP1)

## 1. المتطلبات الأساسية على جهاز Windows
- نظام التشغيل: Windows 10 أو Windows 11 (x64 أو x86).
- بيئة التطوير: `.NET 10 SDK` (مع مكون `Microsoft.WindowsDesktop.App` الخاص بـ WPF).
- قاعدة البيانات: خادم **MariaDB** محلي (الإصدار 10.11 أو أحدث، مهيأ بترميز `utf8mb4`).
- سطر الأوامر: **PowerShell 7.0+** (مطلوب لسكربتات التغليف في `scripts/`).

## 2. بناء الحل الموحد (Solution)
```powershell
dotnet restore Hanouty.sln
dotnet build Hanouty.sln -c Release --no-restore
```

## 3. بناء وتشغيل النسخة الإنتاجية (بدون كود اختبارات القبول)
```powershell
dotnet publish modernization/Hanouty.Desktop.Bootstrap/Hanouty.Desktop.Bootstrap.csproj `
  -c Release -r win-x64 --self-contained true `
  -p:PublishSingleFile=false -p:HanoutyWpfAsLibrary=true `
  -p:ArchitectureProject=modernization/architecture/Hanouty.ArchitectureBridge/Hanouty.ArchitectureBridge.csproj `
  -p:CheckoutProductionProject=modernization/checkout-mariadb-production/CheckoutMariaDbProduction.csproj `
  -o ./dist/publish
```
- **نقطة التشغيل الحقيقية:** `./dist/publish/Hanouty.Desktop.Bootstrap.exe`
- **تهيئة المحطة لأول مرة:** `Hanouty.Desktop.Bootstrap.exe --configure-workstation`

## 4. تشغيل الاختبارات على Windows
```powershell
# 1) اختبارات واجهة WPF (بما فيها اختبار حارس CustomerSettlementDialog)
dotnet run --project modernization/Hanouty.Desktop.Wpf.Tests/Hanouty.Desktop.Wpf.Tests.csproj -c Release

# 2) اختبارات دورة حياة الصندوق (Cell01)
dotnet run --project modernization/architecture/CashboxLifecycle.Tests/CashboxLifecycle.Tests.csproj -c Release

# 3) اختبارات وحدة الترخيص
dotnet run --project licensing/Hanouty.Licensing.Smoke/Hanouty.Licensing.Smoke.csproj -c Release -f net10.0

# 4) اختبارات القبول الشاملة (تتطلب MariaDB محلياً معزولاً على المنفذ 3307)
dotnet run --project modernization/Hanouty.Desktop.Acceptance/Hanouty.Desktop.Acceptance.csproj -c Release -- ./acceptance-evidence.json
```
