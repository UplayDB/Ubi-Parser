using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

namespace UbiParser
{
    public class Parsers
    {
        #region Manifest
        public static Uplay.Download.Manifest ParseManifest(Stream inputStream)
        {
            inputStream.Seek(356, SeekOrigin.Begin);
            var decompressor = new InflaterInputStream(inputStream);
            var result = Uplay.Download.Manifest.Parser.ParseFrom(decompressor);
            decompressor.Close();
            inputStream.Close();
            return result;
        }
        public static Uplay.Download.Manifest ParseManifestFile(string FileInput)
        {
            var result = ParseManifest(File.OpenRead(FileInput));
            return result;
        }
        #endregion
        #region ManifestMetaData
        public static Uplay.Download.ManifestMetaData ParseMetaData(Stream inputStream)
        {
            inputStream.Seek(356, SeekOrigin.Begin);
            var decompressor = new InflaterInputStream(inputStream);
            var result = Uplay.Download.ManifestMetaData.Parser.ParseFrom(decompressor);
            decompressor.Close();
            inputStream.Close();
            return result;
        }
        public static Uplay.Download.ManifestMetaData ParseMetaDataFile(string FileInput)
        {
            var result = ParseMetaData(File.OpenRead(FileInput));
            return result;
        }
        #endregion
        #region ManifestLicenses
        public static Uplay.Download.ManifestLicenses ParseManifestLicenses(Stream inputStream)
        {
            inputStream.Seek(356, SeekOrigin.Begin);
            var decompressor = new InflaterInputStream(inputStream);
            var result = Uplay.Download.ManifestLicenses.Parser.ParseFrom(decompressor);
            decompressor.Close();
            inputStream.Close();
            return result;
        }
        public static Uplay.Download.ManifestLicenses ParseManifestLicensesaFile(string FileInput)
        {
            var result = ParseManifestLicenses(File.OpenRead(FileInput));
            return result;
        }
        #endregion
        #region DownloadCahce
        public static Uplay.DownloadCache.DownloadCache ParseDownloadCache(Stream inputStream)
        {
            inputStream.Seek(2, SeekOrigin.Begin);
            var result = Uplay.DownloadCache.DownloadCache.Parser.ParseFrom(inputStream);
            inputStream.Close();

            return result;
        }

        public static Uplay.DownloadCache.DownloadCache ParseDownloadCacheFile(string FileInput)
        {
            var result = ParseDownloadCache(File.OpenRead(FileInput));
            return result;
        }
        #endregion
        #region ConfigurationCache
        public static Uplay.Configuration.ConfigurationCache ParseConfigurationCache(Stream inputStream)
        {
            var result = Uplay.Configuration.ConfigurationCache.Parser.ParseFrom(inputStream);
            inputStream.Close();

            return result;
        }

        public static Uplay.Configuration.ConfigurationCache ParseConfigurationCacheFile(string FileInput)
        {
            var result = ParseConfigurationCache(File.OpenRead(FileInput));
            return result;
        }
        #endregion
        #region ClubCache
        public static Uplay.ClubCache.ClubCache ParseClubCache(Stream inputStream)
        {
            var result = Uplay.ClubCache.ClubCache.Parser.ParseFrom(inputStream);
            inputStream.Close();

            return result;
        }

        public static Uplay.ClubCache.ClubCache ParseClubCacheFile(string FileInput)
        {
            var result = ParseClubCache(File.OpenRead(FileInput));
            return result;
        }
        #endregion
        #region OwnershipCache
        public static Uplay.OwnershipCache.OwnershipCache ParseOwnerShip(Stream inputStream)
        {
            inputStream.Seek(262, SeekOrigin.Begin);
            var result = Uplay.OwnershipCache.OwnershipCache.Parser.ParseFrom(inputStream);
            inputStream.Close();
            return result;
        }

        public static Uplay.OwnershipCache.OwnershipCache ParseOwnerShipFile(string FileInput)
        {
            var result = ParseOwnerShip(File.OpenRead(FileInput));
            return result;
        }
        #endregion
        #region GameActivationListCache
        public static Uplay.GameActivationsCache.GameActivationListCache ParseActivations(Stream inputStream)
        {
            var result = Uplay.GameActivationsCache.GameActivationListCache.Parser.ParseFrom(inputStream);
            inputStream.Close();

            return result;
        }

        public static Uplay.GameActivationsCache.GameActivationListCache ParseActivationsFile(string FileInput)
        {
            var result = ParseActivations(File.OpenRead(FileInput));
            return result;
        }
        #endregion
        #region DownloadInstallState
        public static Uplay.DownloadInstallState.DownloadInstallState ParseDownloadState(Stream inputStream)
        {
            var result = Uplay.DownloadInstallState.DownloadInstallState.Parser.ParseFrom(inputStream);
            inputStream.Close();
            return result;
        }

        public static Uplay.DownloadInstallState.DownloadInstallState ParseDownloadStateFile(string FileInput)
        {
            var result = ParseDownloadState(File.OpenRead(FileInput));
            return result;
        }
        #endregion
        #region GameStatsCache
        public static Uplay.GameStatsCache.GameStatsCache ParseStats(Stream inputStream)
        {
            var result = Uplay.GameStatsCache.GameStatsCache.Parser.ParseFrom(inputStream);
            inputStream.Close();

            return result;
        }

        public static Uplay.GameStatsCache.GameStatsCache ParseStatsFile(string FileInput)
        {
            var result = ParseStats(File.OpenRead(FileInput));
            return result;
        }
        #endregion
        #region ConversationsCache
        public static Uplay.ConversationsCache.ConversationsCache ParseConversation(Stream inputStream)
        {
            var result = Uplay.ConversationsCache.ConversationsCache.Parser.ParseFrom(inputStream);
            inputStream.Close();

            return result;
        }

        public static Uplay.ConversationsCache.ConversationsCache ParseConversationFile(string FileInput)
        {
            var result = ParseConversation(File.OpenRead(FileInput));
            return result;
        }
        #endregion
        #region PlayTimeCache
        public static Uplay.PlaytimeCache.PlaytimeCache ParsePlaytime(Stream inputStream)
        {
            var result = Uplay.PlaytimeCache.PlaytimeCache.Parser.ParseFrom(inputStream);
            inputStream.Close();

            return result;
        }

        public static Uplay.PlaytimeCache.PlaytimeCache ParsePlaytimeFile(string FileInput)
        {
            var result = ParsePlaytime(File.OpenRead(FileInput));
            return result;
        }
        #endregion
        #region UserDat
        public static Uplay.UserDatFile.Cache ParseUserDat(Stream inputStream)
        {
            var result = Uplay.UserDatFile.Cache.Parser.ParseFrom(inputStream);
            inputStream.Close();

            return result;
        }

        public static Uplay.UserDatFile.Cache ParseUserDatFile(string FileInput)
        {
            var result = ParseUserDat(File.OpenRead(FileInput));
            return result;
        }
        #endregion
        #region UserSettings
        public static Uplay.UserSettings.UserSettings ParseUserSettings(Stream inputStream)
        {
            var result = Uplay.UserSettings.UserSettings.Parser.ParseFrom(inputStream);
            inputStream.Close();

            return result;
        }

        public static Uplay.UserSettings.UserSettings ParseUserSettingsFile(string FileInput)
        {
            var result = ParseUserSettings(File.OpenRead(FileInput));
            return result;
        }
        #endregion
    }
}
