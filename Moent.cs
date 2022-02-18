namespace moent {
    public class Moent {

        public static string Convert(double amount) {
            int earsLeftover = (int)(amount * 100);
            var money = new Dictionary<string, int>();
            double total = 0;
            while (earsLeftover >= 50) {
                switch (earsLeftover) {
                    case >= 1000_00:
                        string thousands = "Tusindkronesedler";
                        if (money.ContainsKey(thousands)) {
                            money[thousands] += 1;
                        } else {
                            money.Add(thousands, 1);
                        }
                        earsLeftover -= 1000_00;
                        total += 1000;
                        break;
                    case >= 500_00:
                        string fiveHundreds = "Femhundredekronesedler";
                        if (money.ContainsKey(fiveHundreds)) {
                            money[fiveHundreds] += 1;
                        } else {
                            money.Add(fiveHundreds, 1);
                        }
                        earsLeftover -= 500_00;
                        total += 500;
                        break;
                    case >= 200_00:
                        string twoHundreds = "Tohundredekronesedler";
                        if (money.ContainsKey(twoHundreds)) {
                            money[twoHundreds] += 1;
                        } else {
                            money.Add(twoHundreds, 1);
                        }
                        earsLeftover -= 200_00;
                        total += 200;
                        break;
                    case >= 100_00:
                        string hundreds = "Hundredekronesedler";
                        if (money.ContainsKey(hundreds)) {
                            money[hundreds] += 1;
                        } else {
                            money.Add(hundreds, 1);
                        }
                        earsLeftover -= 100_00;
                        total += 100;
                        break;
                    case >= 50_00:
                        string fifties = "Halvtredskronesedler";
                        if (money.ContainsKey(fifties)) {
                            money[fifties] += 1;
                        } else {
                            money.Add(fifties, 1);
                        }
                        earsLeftover -= 50_00;
                        total += 50;
                        break;
                    case >= 20_00:
                        string twenties = "Tyvere";
                        if (money.ContainsKey(twenties)) {
                            money[twenties] += 1;
                        } else {
                            money.Add(twenties, 1);
                        }
                        earsLeftover -= 20_00;
                        total += 20;
                        break;
                    case >= 10_00:
                        string tens = "Tiere";
                        if (money.ContainsKey(tens)) {
                            money[tens] += 1;
                        } else {
                            money.Add(tens, 1);
                        }
                        earsLeftover -= 10_00;
                        total += 10;
                        break;
                    case >= 5_00:
                        string fives = "Femmere";
                        if (money.ContainsKey(fives)) {
                            money[fives] += 1;
                        } else {
                            money.Add(fives, 1);
                        }
                        earsLeftover -= 5_00;
                        total += 5;
                        break;
                    case >= 2_00:
                        string twos = "Tokroner";
                        if (money.ContainsKey(twos)) {
                            money[twos] += 1;
                        } else {
                            money.Add(twos, 1);
                        }
                        earsLeftover -= 2_00;
                        total += 2;
                        break;
                    case >= 1_00:
                        string ones = "Enkroner";
                        if (money.ContainsKey(ones)) {
                            money[ones] += 1;
                        } else {
                            money.Add(ones, 1);
                        }
                        earsLeftover -= 1_00;
                        total += 1;
                        break;
                    case >= 50:
                        string pointFifties = "Halvtredsører";
                        if (money.ContainsKey(pointFifties)) {
                            money[pointFifties] += 1;
                        } else {
                            money.Add(pointFifties, 1);
                        }
                        earsLeftover -= 50;
                        total += .5;
                        break;
                }
            }
            string line = "-----------------------------------------\n";
            string rs = line;
            foreach (var kvp in money) {
                string k = kvp.Key;
                int v = kvp.Value;
                rs += String.Format("{0, -25}: {1, 7}\n", k, v);
            }


            rs += line;
            rs += String.Format("{0}: {1:C2} \n", "I alt", total);
            rs += line;
            return rs;
        }
    }
}