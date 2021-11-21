using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace BoringBudget
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            SetLanguageDictionary();
        }

        private void SetLanguageDictionary()
        {
            switch (Thread.CurrentThread.CurrentCulture.ToString())
            {
                case "fr-FR":
                    BoringBudget.Language.Resources.Culture = new System.Globalization.CultureInfo("fr-FR");
                    break;
                case "en-GB":
                    BoringBudget.Language.Resources.Culture = new System.Globalization.CultureInfo("en-GB");
                    break;
                default:
                    BoringBudget.Language.Resources.Culture = new System.Globalization.CultureInfo("en-GB");
                    break;
            }
        }

    }
}
