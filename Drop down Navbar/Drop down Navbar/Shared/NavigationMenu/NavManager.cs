using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drop_down_Navbar.Shared.NavigationMenu
{
    public class NavManager
    {
        static List<NavButton> NavDashboardSection = new();

        static List<NavButton> NavAccountSection = new()
        {
            new NavButton("Personel Detials", "/account/detials"),
            new NavButton("Achievements", "/account/achievements"),
            new NavButton("Activity", "/account/activity"),
            new NavButton("Referrals", "/account/referrals")
        };

        static List<NavButton> NavGamerProfileSection = new()
        {
            new NavButton("My Game Profile", "/profile"),
            new NavButton("My Game Genres", "/profile/genres"),
            new NavButton("My Game Devices", "/profile/devices")
        };

        static List<NavButton> NavTestSection = new()
        {
            new NavButton("Available Tests", "/tests"),
            new NavButton("Test History", "/tests/history")
        };

        static List<NavButton> NavShopSection = new()
        {
            new NavButton("Browse", "/shop"),
            new NavButton("Address Book", "/shop/addressbook"),
            new NavButton("Order History", "/shop/orderhistory"),
        };

        static List<NavButton> NavSupportSection = new()
        {
            new NavButton("Tickets", "/support/tickets"),
            new NavButton("Legal", "/support/legal"),
            new NavButton("FAQ", "/support/faq")
        };

        public static List<NavButton> MainNavButtons = new()
        {
            new NavButton("Dashboard", "/dashboard", NavSection.Dashboard, NavDashboardSection),
            new NavButton("Account", "/account", NavSection.Account, NavAccountSection),
            new NavButton("Gamer Profile", "/gamerprofile", NavSection.GameProfile, NavGamerProfileSection),
            new NavButton("Tests", "/tests", NavSection.Tests, NavTestSection),
            new NavButton("Shop", "/shop", NavSection.Shop, NavShopSection),
            new NavButton("Support", "/support/ticekts", NavSection.Support, NavSupportSection)
        };

        public class NavButton
        {
            public NavButton(string buttonString, string buttonRoute, NavSection section = NavSection.Dashboard, List<NavButton> subSection = null)
            {
                ButtonString = buttonString;
                ButtonRoute = buttonRoute;
                Section = section;
                SubSection = subSection;
            }

            public string ButtonString { get; set; }

            public string ButtonRoute { get; set; }

            public NavSection Section { get; set; } = NavSection.Dashboard;

            public List<NavButton> SubSection { get; set; } = new List<NavButton>();

            public string StyleClassString { get; set; } = NavigationMenu.ButtonActiveStyle.normal;

        }
    }

    public enum NavSection
    {
        None,
        Dashboard,
        Account,
        GameProfile,
        Tests,
        Shop,
        Support
    }


}
