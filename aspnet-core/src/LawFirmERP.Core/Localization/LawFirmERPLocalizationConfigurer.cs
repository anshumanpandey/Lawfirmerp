using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace LawFirmERP.Localization
{
    public static class LawFirmERPLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(LawFirmERPConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(LawFirmERPLocalizationConfigurer).GetAssembly(),
                        "LawFirmERP.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
