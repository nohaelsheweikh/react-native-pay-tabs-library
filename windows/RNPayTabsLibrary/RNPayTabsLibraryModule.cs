using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Pay.Tabs.Library.RNPayTabsLibrary
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNPayTabsLibraryModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNPayTabsLibraryModule"/>.
        /// </summary>
        internal RNPayTabsLibraryModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNPayTabsLibrary";
            }
        }
    }
}
