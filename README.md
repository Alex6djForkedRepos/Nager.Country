# 🌍 Nager.Country – Worldwide Country Information

**Nager.Country** provides a comprehensive dataset of **worldwide country information**, designed for developers who need reliable and structured country-related data.

The dataset includes **250 countries and territories** with detailed information such as:

- ✅ Official country names  
- 🌐 ISO 3166 Alpha-2, Alpha-3, and numeric country codes  
- 💱 Associated currencies and ISO 4217 currency codes  
- 🗣️ Official and spoken languages (ISO 639)  
- 🌍 Continent and subregion classification  
- 🌐 Country borders
- 🌏 Translations in multiple languages

## 📦 Access & Installation

You can access the data in two ways:

- Via [NuGet package](https://www.nuget.org/packages/Nager.Country) – ideal for .NET applications  
- As a downloadable ZIP archive containing structured JSON files ([latest zip package](https://github.com/nager/Nager.Country/releases/latest/download/countries.zip))

## 🎯 Use Cases

Perfect for projects that require up-to-date and standardized country data, such as:

- International e-commerce systems  
- Travel and booking platforms  
- Localization (i18n) features  
- Data validation and enrichment  
- Geographic analytics and reporting

## nuget [![nuget.org download count](https://img.shields.io/nuget/dt/nager.country.svg)](https://www.nuget.org/packages/Nager.Country/)

The project is available as NuGet packages for easy integration into any .NET application.

### 📚 Core Package –  `Nager.Country`

🔗 [View on NuGet.org →](https://www.nuget.org/packages/Nager.Country)

```
PM> install-package Nager.Country
```

### 🌐 Optional Package – `Nager.Country.Translation`

Provides localized country names (translations based on the `commonName` in multiple languages).

🔗 [View on NuGet.org →](https://www.nuget.org/packages/Nager.Country.Translation)

```
PM> install-package Nager.Country.Translation
```

## Examples of use

### Get all available countries

Retrieve a full list of all 250 countries and territories.

```cs
var countryProvider = new CountryProvider();
var countries = countryProvider.GetCountries();
```

### Lookup a country by its English name

Get detailed information by specifying the official English country name.

```cs
var countryProvider = new CountryProvider();
var countryInfo = countryProvider.GetCountryByName("Germany");
//countryInfo.Alpha2Code -> DE
//countryInfo.Alpha3Code -> DEU
//countryInfo.NumericCode -> 276
//countryInfo.Region -> Europe
//countryInfo.SubRegion -> WesternEurope
//countryInfo...
```

### Lookup a country by localized name (with translation support)

Enables country name lookup using translations (e.g. "Germania" instead of "Germany").

➡️ Requires the translation package [Nager.Country.Translation](https://www.nuget.org/packages/Nager.Country.Translation)

```cs
var countryProvider = new CountryProvider();
var countryInfo = countryProvider.GetCountryByNameConsiderTranslation("Germania"); // <- Germany
//countryInfo.Alpha2Code -> DE
//countryInfo.Alpha3Code -> DEU
//countryInfo.NumericCode -> 276
//countryInfo.Region -> Europe
//countryInfo.SubRegion -> WesternEurope
//countryInfo...
```

### Get a country's name in a specific language

Translate the official country name into a desired language.

➡️ Requires the translation package [Nager.Country.Translation](https://www.nuget.org/packages/Nager.Country.Translation)

```cs
var translationProvider = new TranslationProvider();
var translatedCountryName = translationProvider.GetCountryTranslatedName(Alpha2Code.DE, LanguageCode.EN);
//translatedCountryName -> Germany
```

### Get all supported languages

List all language codes available for translation purposes.
➡️ Requires the translation package [Nager.Country.Translation](https://www.nuget.org/packages/Nager.Country.Translation)

```cs
var translationProvider = new TranslationProvider();
var languages = translationProvider.GetLanguages();
```

## 🌐 Related & Interesting Projects

Here are some useful projects that also provide country-related data, validation, or localization features:

| Language | Project | 
| ------------- | ------------- | 
| * | [mledoze countries](https://github.com/mledoze/countries) |
| * | [umpirsky country-list](https://github.com/umpirsky/country-list) |
| * | [dr5hn countries-states-cities-database](https://github.com/dr5hn/countries-states-cities-database) |
| javascript | [michaelwittig node-i18n-iso-countries](https://github.com/michaelwittig/node-i18n-iso-countries) |
| .net | [anghelvalentin CountryValidator](https://github.com/anghelvalentin/CountryValidator) |
