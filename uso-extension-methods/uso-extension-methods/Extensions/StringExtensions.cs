using System;


namespace Extensions {// Se trocar aqui por'System' não teria que importar de 'Extensions'
    static class StringExtensions {
        public static string Cut(this string thisObj, int count) {
            if (thisObj.Length <= count) {
                return thisObj;
            }
            else {
                return thisObj.Substring(0, count) + "...";
            }
        }
    }
}
