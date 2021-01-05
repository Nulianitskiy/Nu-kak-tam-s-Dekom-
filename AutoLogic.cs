using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Ну_как_там_с_деком
{
    class AutoLogic
    {
        Dictionary<string, string[]> grammar = new Dictionary<string, string[]>();

        bool stor;

        public AutoLogic(string s)
        {
            Regex neter = new Regex(@"[A-Z]{1}");
            Regex prow = new Regex(@"^[A-Z]{1}$");
            Regex prowr = new Regex(@"^[A-Z]?[a-z]{1}$");
            Regex prowl = new Regex(@"^[a-z]{1}[A-Z]?$");

            string[] lines = s.Split('\n');

            string[][] Storage = new string[lines.Length][];
            for (int i = 0; i < Storage.Length; i++)
            {
                Storage[i] = new string[lines[i].Length];
                Storage[i] = lines[i].Split('-');

            }

            for (int i = 0; i < Storage.Length; i++)
            {
                grammar.Add(Storage[i][0], Storage[i][1].Split('|'));
            }
            foreach (string i in grammar.Keys)
            {
                if (!prow.IsMatch(i))
                    throw new Exception();
            }
            bool l = true, r = true;

            foreach (string[] i in grammar.Values)
            {
                for (int j = 0; j < i.Length; j++)
                {
                    if (l)
                        l = prowl.IsMatch(i[j]);
                    if (r)
                        r = prowr.IsMatch(i[j]);
                    if (!l && !r)
                        break;
                    if (neter.IsMatch(i[j]))
                    {
                        Match Term = neter.Match(i[j]);
                        if (!grammar.ContainsKey(Term.Value))
                            throw new Exception();
                    }
                }
                if (!l && !r)
                    break;
            }
            if (!l && !r)
                throw new Exception();

            if (l) 
                stor = true;
            else 
                stor = false;

            if (!grammar.ContainsKey("S"))
                throw new Exception();

        }
        public bool CheckWord(string s)
        {
            Regex neter = new Regex(@"[A-Z]{1}");
            Regex ter = new Regex(@"[a-z]{1}");

            if (!stor)
            {
                char rez;
                StringBuilder s1 = new StringBuilder(s);
                for (int i = 0; i < s.Length / 2; i++)
                {
                    rez = s1[i];
                    s1[i] = s[s1.Length - i - 1];
                    s1[s1.Length - i - 1] = rez;
                }
                s = s1.ToString();
            }
            return Check(0, "S");

            bool Check(int n, string terminal, bool c = false)
            {

                string[] stroka;
                grammar.TryGetValue(terminal, out stroka);
                Match Term;

                for (int i = 0; i < stroka.Length && !c; i++)
                {
                    Term = ter.Match(stroka[i]);
                    if (Term.Value[0] == s[n])
                    {
                        if ((n != s.Length - 1) && (!c) && (neter.IsMatch(stroka[i])))
                        { 
                            Term = neter.Match(stroka[i]);
                            c = Check(n + 1, Term.Value);
                        }
                        else if ((n == s.Length - 1) && (!neter.IsMatch(stroka[i])))
                            return true;
                    }
                }
                return c;
            }
        }
    }
}
