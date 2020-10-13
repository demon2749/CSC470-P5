using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5_Code
{
    public class FakePreferenceRepository : IPreferenceRepository
    {

        private static Dictionary<string, Dictionary<string, string>> Preferences;

        public FakePreferenceRepository()
        {
            if (Preferences == null)
            {
                Preferences = new Dictionary<string, Dictionary<string, string>>();
            }
        }

        public string GetPreference(string UserName, string PreferenceName)
        {
            throw new NotImplementedException();// ----------------------------------------------------------------------------------------------!!
        }
        public string SetPreference(string UserName, string PreferenceName, string Value)
        {
            throw new NotImplementedException();// ----------------------------------------------------------------------------------------------!!
        }
    }
}
