using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Modul_202107.Localization
{
    public static class Modul_202107LocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(Modul_202107Consts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(Modul_202107LocalizationConfigurer).GetAssembly(),
                        "Modul_202107.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
