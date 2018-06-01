using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RechnermodulBibliothek;

namespace Rechnermodul
{
    class EingabeManager
    {
        private class UserData : RechnermodulBibliothek.UserDataInterface
        {
            private Dictionary<string, string> values;
            private Dictionary<string, string[]> arrays;

            public UserData(Dictionary<string, string> stringValues, Dictionary<string, string[]> stringArrays)
            {
                this.values = stringValues;
                this.arrays = stringArrays;
            }

            string RechnermodulBibliothek.UserDataInterface.getStringValue(string key)
            {
                if (!this.values.ContainsKey(key))
                {
                    throw new Exception("Der Schlüssel ist halt nicht verfügbar");
                }
                return this.values[key];
            }

            string[] RechnermodulBibliothek.UserDataInterface.getStringArray(string key)
            {
                if (!this.arrays.ContainsKey(key))
                {
                    throw new Exception("Der Schlüssel ist halt nicht verfügbar");
                }
                return this.arrays[key];
            }
        }

        public UserDataInterface getUserData(UIBuilderInterface uiBuilder)
        {
            Dictionary<string, string> stringValues = new Dictionary<string, string>();
            Dictionary<string, List<string>> arrayValues = new Dictionary<string, List<string>>();

            UIElement[] uiElements = uiBuilder.getUIElements();
            int element_count = uiElements.Length;
            int current_param = 0;

            foreach (UIElement element in uiElements)
            {
                if (element.getType() == UIElement.TYPE_SINGLE)
                {
                    stringValues[element.getKey()] = "";
                }
                else
                {
                    arrayValues[element.getKey()] = new List<string>();
                }
            }

            while (current_param < element_count)
            {
                UIElement current_element = uiElements[current_param];

                universelleseingabemodul uem = new universelleseingabemodul();
                uem.buildUi(uiElements[current_param]);
                uem.ShowDialog();

                if (current_element.getType() == UIElement.TYPE_SINGLE)
                {
                    stringValues[current_element.getKey()] = uem.getData();
                } 
                else
                {
                    arrayValues[current_element.getKey()].Add(uem.getData());
                }

                if (uem.state == universelleseingabemodul.STATE_NEXT_PARAM)
                {
                    current_param++;
                }
                else if (uem.state != universelleseingabemodul.STATE_NEXT_VALUE)
                {
                    return null;
                }
            }


            Dictionary<string, string[]> arrayDict = new Dictionary<string, string[]>();

            foreach (string key in arrayValues.Keys)
            {
                arrayDict[key] = arrayValues[key].ToArray<string>();
            }

            return new UserData(stringValues, arrayDict);
        }
    }
}
