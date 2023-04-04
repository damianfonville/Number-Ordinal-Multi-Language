using System;
using System.Collections;
using System.Data;
using OutSystems.HubEdition.RuntimePlatform;

namespace OutSystems.NssNumberOrdinalMultiLanguage_EXT {

	public interface IssNumberOrdinalMultiLanguage_EXT {

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssNumber"></param>
		/// <param name="ssLanguage"></param>
		/// <param name="ssGender"></param>
		/// <param name="ssOrdinalNumber"></param>
		void MssToOrdinalNumber(int ssNumber, string ssLanguage, string ssGender, out string ssOrdinalNumber);

	} // IssNumberOrdinalMultiLanguage_EXT

} // OutSystems.NssNumberOrdinalMultiLanguage_EXT
