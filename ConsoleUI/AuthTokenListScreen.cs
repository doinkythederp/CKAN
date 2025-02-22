using System;
using System.ComponentModel;
using System.Collections.Generic;

using Autofac;

using CKAN.ConsoleUI.Toolkit;
using CKAN.Configuration;

namespace CKAN.ConsoleUI {

    /// <summary>
    /// Screen for display and editing of authentication tokens.
    /// </summary>
    public class AuthTokenScreen : ConsoleScreen {

        /// <summary>
        /// Initialize the screen.
        /// </summary>
        public AuthTokenScreen(ConsoleTheme theme) : base(theme)
        {
            mainMenu = new ConsolePopupMenu(new List<ConsoleMenuOption?>() {
                new ConsoleMenuOption(Properties.Resources.AuthTokenListGitHubLink, "",
                    Properties.Resources.AuthTokenListGitHubLinkTip,
                    true, openGitHubURL)
            });

            AddObject(new ConsoleLabel(
                1, 2, -1,
                () => Properties.Resources.AuthTokenListLabel
            ));

            tokenList = new ConsoleListBox<string>(
                1, 4, -1, -2,
                new List<string>(ServiceLocator.Container.Resolve<IConfiguration>().GetAuthTokenHosts()),
                new List<ConsoleListBoxColumn<string>>() {
                    new ConsoleListBoxColumn<string>(
                        Properties.Resources.AuthTokenListHostHeader,
                        s => s, null, 20),
                    new ConsoleListBoxColumn<string>(
                        Properties.Resources.AuthTokenListTokenHeader,
                        s => {
                            return ServiceLocator.Container.Resolve<IConfiguration>().TryGetAuthToken(s, out string? token)
                                ? token
                                : Properties.Resources.AuthTokenListMissingToken;
                        }, null, null),
                },
                0, 0, ListSortDirection.Descending
            );
            AddObject(tokenList);

            AddObject(new ConsoleLabel(
                3, -1, -1,
                () => Properties.Resources.AuthTokenListWarning,
                null,
                th => th.AlertFrameFg
            ));

            AddTip(Properties.Resources.Esc, Properties.Resources.Back);
            AddBinding(Keys.Escape, sender => false);

            tokenList.AddTip("A", Properties.Resources.Add);
            tokenList.AddBinding(Keys.A, sender =>
            {
                var ad = new AuthTokenAddDialog(theme);
                ad.Run();
                DrawBackground();
                tokenList.SetData(new List<string>(ServiceLocator.Container.Resolve<IConfiguration>().GetAuthTokenHosts()));
                return true;
            });

            tokenList.AddTip("R", Properties.Resources.Remove, () => tokenList.Selection != null);
            tokenList.AddBinding(Keys.R, sender =>
            {
                if (tokenList.Selection != null) {
                    ServiceLocator.Container.Resolve<IConfiguration>().SetAuthToken(tokenList.Selection, null);
                    tokenList.SetData(new List<string>(ServiceLocator.Container.Resolve<IConfiguration>().GetAuthTokenHosts()));
                }
                return true;
            });
        }

        /// <summary>
        /// Put CKAN 1.25.5 in top left corner
        /// </summary>
        protected override string LeftHeader()
            => $"{Meta.ProductName} {Meta.GetVersion()}";

        /// <summary>
        /// Put description in top center
        /// </summary>
        protected override string CenterHeader()
            => Properties.Resources.AuthTokenListTitle;

        private bool openGitHubURL()
        {
            ModInfoScreen.LaunchURL(theme, githubTokenURL);
            return true;
        }

        private readonly ConsoleListBox<string> tokenList;

        private static readonly Uri githubTokenURL = new Uri("https://github.com/settings/tokens");
    }

}
