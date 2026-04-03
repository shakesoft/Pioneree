# Generate Localization

Add localization entries to PionereeDemo.xml with duplicate detection.

## Usage

`/generate-localization {key=value pairs}` — Comma-separated key=value pairs

## CRITICAL

**ABP throws `AbpException` on duplicate keys.** This command always searches first.

## What It Does

1. **Searches** existing keys in all XML files to prevent duplicates
2. **Adds** new entries to `PionereeDemo.xml` (English)
3. **Reports** which keys already existed and were skipped

## File Location

```
aspnet-core/src/PionereeDemo.Core/Localization/PionereeDemo/PionereeDemo.xml
```

## Search Command

```powershell
Select-String -Pattern 'name="KeyName"' -Path aspnet-core/src/PionereeDemo.Core/Localization/PionereeDemo/*.xml
```

## Example

```
/generate-localization Products=Products,CreateNewProduct=Create new product,EditProduct=Edit product
```

Adds (if not already present):
```xml
<text name="Products">Products</text>
<text name="CreateNewProduct">Create new product</text>
<text name="EditProduct">Edit product</text>
```
