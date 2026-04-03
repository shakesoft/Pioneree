using System.Reflection;
using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace PionereeDemo.Localization;

public static class PionereeDemoLocalizationConfigurer
{
    public static void Configure(ILocalizationConfiguration localizationConfiguration)
    {
        localizationConfiguration.Sources.Add(
            new DictionaryBasedLocalizationSource(
                PionereeDemoConsts.LocalizationSourceName,
                new XmlEmbeddedFileLocalizationDictionaryProvider(
                    typeof(PionereeDemoLocalizationConfigurer).GetAssembly(),
                    "PionereeDemo.Localization.PionereeDemo"
                )
            )
        );
    }
}

