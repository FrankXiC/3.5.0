using System.Reflection;
using Abp.Configuration.Startup;
using Abp.Localization;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Json;
using Abp.Reflection.Extensions;

namespace TESTABP.Localization {
    public static class TESTABPLocalizationConfigurer {
        public static void Configure(ILocalizationConfiguration localizationConfiguration) {
            localizationConfiguration.Languages.Add(new LanguageInfo("en", "English", "famfamfam-flags england", isDefault: true));
            localizationConfiguration.Languages.Add(new LanguageInfo("tr", "Türkçe", "famfamfam-flags tr"));

            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(TESTABPConsts.LocalizationSourceName,
                    new JsonEmbeddedFileLocalizationDictionaryProvider(
                        typeof(TESTABPLocalizationConfigurer).GetAssembly(),
                        "TESTABP.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}