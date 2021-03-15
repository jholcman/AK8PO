using System;
using System.Windows.Forms;

namespace UtilityLibraries
{
    public static class StringLibrary
    {
        public static String DatabazeRetezec()
        {
            return @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'D:\UTB\1. ročník LS\AK8PO - Pokročilé programování\Projek\AK8PO\AK8PO\DatabaseUTB.mdf'; Integrated Security = True";
        }
        public static String[] JazykRetezec()
        {
            string[] jazyky = { "CZ", "ANG", "NEM" };
            return jazyky;
        }
        public static String[] FormaStudiaRetezec()
        {
            string[] formaStudia = { "P", "K", "PH" };
            return formaStudia;
        }
        public static String[] TypStudiaRetezec()
        {
            string[] typStudia = { "Bc.", "Mgr.", "Ph.D." };
            return typStudia;
        }
        public static String[] SemestrRetezec()
        {
            string[] semestrStudia = { "ZS", "LS" };
            return semestrStudia;
        }
        public static String[] ZakonceniRetezec()
        {
            string[] zakonceniStudia = { "z", "zk", "kz" };
            return zakonceniStudia;
        }
        public static void Generuj(ComboBox c, string[] s, int i)
        {
            c.Items.Clear();
            c.Items.AddRange(s);
            c.SelectedIndex = i;
        }
    }
}