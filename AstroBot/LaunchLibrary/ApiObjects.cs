// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace AstroBot.LaunchLibrary
{

    public class Status
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class LaunchServiceProvider
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("featured")]
        public bool Featured { get; set; }

        [JsonProperty("type")]
        public object Type { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("abbrev")]
        public string Abbrev { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("administrator")]
        public string Administrator { get; set; }

        [JsonProperty("founding_year")]
        public string FoundingYear { get; set; }

        [JsonProperty("launchers")]
        public string Launchers { get; set; }

        [JsonProperty("spacecraft")]
        public string Spacecraft { get; set; }

        [JsonProperty("launch_library_url")]
        public string LaunchLibraryUrl { get; set; }

        [JsonProperty("total_launch_count")]
        public int TotalLaunchCount { get; set; }

        [JsonProperty("consecutive_successful_launches")]
        public int ConsecutiveSuccessfulLaunches { get; set; }

        [JsonProperty("successful_launches")]
        public int SuccessfulLaunches { get; set; }

        [JsonProperty("failed_launches")]
        public int FailedLaunches { get; set; }

        [JsonProperty("pending_launches")]
        public int PendingLaunches { get; set; }

        [JsonProperty("consecutive_successful_landings")]
        public int ConsecutiveSuccessfulLandings { get; set; }

        [JsonProperty("successful_landings")]
        public int SuccessfulLandings { get; set; }

        [JsonProperty("failed_landings")]
        public int FailedLandings { get; set; }

        [JsonProperty("attempted_landings")]
        public int AttemptedLandings { get; set; }

        [JsonProperty("info_url")]
        public string InfoUrl { get; set; }

        [JsonProperty("wiki_url")]
        public string WikiUrl { get; set; }

        [JsonProperty("logo_url")]
        public string LogoUrl { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("nation_url")]
        public string NationUrl { get; set; }
    }

    public class Manufacturer
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("featured")]
        public bool Featured { get; set; }

        [JsonProperty("type")]
        public object Type { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("abbrev")]
        public string Abbrev { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("administrator")]
        public string Administrator { get; set; }

        [JsonProperty("founding_year")]
        public string FoundingYear { get; set; }

        [JsonProperty("launchers")]
        public string Launchers { get; set; }

        [JsonProperty("spacecraft")]
        public string Spacecraft { get; set; }

        [JsonProperty("launch_library_url")]
        public string LaunchLibraryUrl { get; set; }

        [JsonProperty("total_launch_count")]
        public int TotalLaunchCount { get; set; }

        [JsonProperty("consecutive_successful_launches")]
        public int ConsecutiveSuccessfulLaunches { get; set; }

        [JsonProperty("successful_launches")]
        public int SuccessfulLaunches { get; set; }

        [JsonProperty("failed_launches")]
        public int FailedLaunches { get; set; }

        [JsonProperty("pending_launches")]
        public int PendingLaunches { get; set; }

        [JsonProperty("consecutive_successful_landings")]
        public int ConsecutiveSuccessfulLandings { get; set; }

        [JsonProperty("successful_landings")]
        public int SuccessfulLandings { get; set; }

        [JsonProperty("failed_landings")]
        public int FailedLandings { get; set; }

        [JsonProperty("attempted_landings")]
        public int AttemptedLandings { get; set; }

        [JsonProperty("info_url")]
        public string InfoUrl { get; set; }

        [JsonProperty("wiki_url")]
        public string WikiUrl { get; set; }

        [JsonProperty("logo_url")]
        public string LogoUrl { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("nation_url")]
        public string NationUrl { get; set; }
    }

    public class Configuration
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("launch_library_id")]
        public int LaunchLibraryId { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("manufacturer")]
        public Manufacturer Manufacturer { get; set; }

        [JsonProperty("program")]
        public List<object> Program { get; set; }

        [JsonProperty("variant")]
        public string Variant { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("min_stage")]
        public int MinStage { get; set; }

        [JsonProperty("max_stage")]
        public int MaxStage { get; set; }

        [JsonProperty("length")]
        public object Length { get; set; }

        [JsonProperty("diameter")]
        public object Diameter { get; set; }

        [JsonProperty("maiden_flight")]
        public object MaidenFlight { get; set; }

        [JsonProperty("launch_mass")]
        public object LaunchMass { get; set; }

        [JsonProperty("leo_capacity")]
        public int LeoCapacity { get; set; }

        [JsonProperty("gto_capacity")]
        public object GtoCapacity { get; set; }

        [JsonProperty("to_thrust")]
        public object ToThrust { get; set; }

        [JsonProperty("apogee")]
        public object Apogee { get; set; }

        [JsonProperty("vehicle_range")]
        public object VehicleRange { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("info_url")]
        public object InfoUrl { get; set; }

        [JsonProperty("wiki_url")]
        public string WikiUrl { get; set; }

        [JsonProperty("total_launch_count")]
        public int TotalLaunchCount { get; set; }

        [JsonProperty("consecutive_successful_launches")]
        public int ConsecutiveSuccessfulLaunches { get; set; }

        [JsonProperty("successful_launches")]
        public int SuccessfulLaunches { get; set; }

        [JsonProperty("failed_launches")]
        public int FailedLaunches { get; set; }

        [JsonProperty("pending_launches")]
        public int PendingLaunches { get; set; }
    }

    public class Rocket
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("configuration")]
        public Configuration Configuration { get; set; }

        [JsonProperty("launcher_stage")]
        public List<object> LauncherStage { get; set; }

        [JsonProperty("spacecraft_stage")]
        public object SpacecraftStage { get; set; }
    }

    public class Mission
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("launch_library_id")]
        public int LaunchLibraryId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("launch_designator")]
        public object LaunchDesignator { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("orbit")]
        public object Orbit { get; set; }
    }

    public class Location
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("map_image")]
        public string MapImage { get; set; }

        [JsonProperty("total_launch_count")]
        public int TotalLaunchCount { get; set; }

        [JsonProperty("total_landing_count")]
        public int TotalLandingCount { get; set; }
    }

    public class Pad
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("agency_id")]
        public object AgencyId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("info_url")]
        public object InfoUrl { get; set; }

        [JsonProperty("wiki_url")]
        public string WikiUrl { get; set; }

        [JsonProperty("map_url")]
        public string MapUrl { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("map_image")]
        public string MapImage { get; set; }

        [JsonProperty("total_launch_count")]
        public int TotalLaunchCount { get; set; }
    }

    public class InfoURL
    {
        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("feature_image")]
        public object FeatureImage { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class Launch
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("launch_library_id")]
        public int LaunchLibraryId { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }

        [JsonProperty("net")]
        public DateTime Net { get; set; }

        [JsonProperty("window_end")]
        public DateTime WindowEnd { get; set; }

        [JsonProperty("window_start")]
        public DateTime WindowStart { get; set; }

        [JsonProperty("inhold")]
        public bool Inhold { get; set; }

        [JsonProperty("tbdtime")]
        public bool Tbdtime { get; set; }

        [JsonProperty("tbddate")]
        public bool Tbddate { get; set; }

        [JsonProperty("probability")]
        public int Probability { get; set; }

        [JsonProperty("holdreason")]
        public string Holdreason { get; set; }

        [JsonProperty("failreason")]
        public object Failreason { get; set; }

        [JsonProperty("hashtag")]
        public object Hashtag { get; set; }

        [JsonProperty("launch_service_provider")]
        public LaunchServiceProvider LaunchServiceProvider { get; set; }

        [JsonProperty("rocket")]
        public Rocket Rocket { get; set; }

        [JsonProperty("mission")]
        public Mission Mission { get; set; }

        [JsonProperty("pad")]
        public Pad Pad { get; set; }

        [JsonProperty("infoURLs")]
        public List<InfoURL> InfoURLs { get; set; }

        [JsonProperty("vidURLs")]
        public List<object> VidURLs { get; set; }

        [JsonProperty("webcast_live")]
        public bool WebcastLive { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("infographic")]
        public string Infographic { get; set; }

        [JsonProperty("program")]
        public List<object> Program { get; set; }

        [JsonProperty("orbital_launch_attempt_count")]
        public int OrbitalLaunchAttemptCount { get; set; }

        [JsonProperty("location_launch_attempt_count")]
        public int LocationLaunchAttemptCount { get; set; }

        [JsonProperty("pad_launch_attempt_count")]
        public int PadLaunchAttemptCount { get; set; }

        [JsonProperty("agency_launch_attempt_count")]
        public int AgencyLaunchAttemptCount { get; set; }

        [JsonProperty("orbital_launch_attempt_count_year")]
        public int OrbitalLaunchAttemptCountYear { get; set; }

        [JsonProperty("location_launch_attempt_count_year")]
        public int LocationLaunchAttemptCountYear { get; set; }

        [JsonProperty("pad_launch_attempt_count_year")]
        public int PadLaunchAttemptCountYear { get; set; }

        [JsonProperty("agency_launch_attempt_count_year")]
        public int AgencyLaunchAttemptCountYear { get; set; }
    }

    public class Root
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public object Previous { get; set; }

        [JsonProperty("results")]
        public List<Launch> Results { get; set; }
    }

}
