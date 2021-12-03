using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgnChecker
{
    public class EgnValidator
    {
        internal Dictionary<string, IEnumerable<int>> regions = new Dictionary<string, IEnumerable<int>>()
        {
            {"Благоевград", Enumerable.Range(0, 43)},
            {"Бургас", Enumerable.Range(44, 93)},
            {"Варна", Enumerable.Range(94,139)},
            {"Велико Търново", Enumerable.Range(140,169)},
            {"Видин", Enumerable.Range(170,183)},
            {"Враца", Enumerable.Range(184,217)},
            {"Габрово", Enumerable.Range(218,233)},
            {"Кърджали", Enumerable.Range(234,281)},
            {"Кюстендил", Enumerable.Range(282,301)},
            {"Ловеч", Enumerable.Range(302,319)},
            {"Монтана", Enumerable.Range(320,341)},
            {"Пазарджик", Enumerable.Range(342,377)},
            {"Перник", Enumerable.Range(378,395)},
            {"Плевен", Enumerable.Range(396,435)},
            {"Пловдив", Enumerable.Range(436,501)},
            {"Разград", Enumerable.Range(502,527)},
            {"Русе", Enumerable.Range(528,555)},
            {"Силистра", Enumerable.Range(556,575)},
            {"Сливен", Enumerable.Range(576,601)},
            {"Смолян", Enumerable.Range(602,623)},
            {"София – град", Enumerable.Range(624,721)},
            {"София – окръг", Enumerable.Range(722,751)},
            {"Стара Загора", Enumerable.Range(752,789)},
            {"Добрич", Enumerable.Range(790,821)},
            {"Толбухин", Enumerable.Range(790,821)},
            {"Търговище", Enumerable.Range(822,843)},
            {"Хасково", Enumerable.Range(844,871)},
            {"Шумен", Enumerable.Range(872,903)},
            {"Ямбол", Enumerable.Range(904,925)},
            {"Друг/Неизвестен", Enumerable.Range(926,999)}
        };
        
        public EgnValidator(string egn)
        {
            this.Egn = egn;
        }
        public string Egn { get; }

        /// <summary>
        /// Checks if all EGN attributes are valid
        /// </summary>
        /// <returns>true if all are valid, false if one of them is not valid</returns>
        public bool IsValid()
        {
            return DateOfBirthIsValid() && RegionIsValid() && TenthDigitIsValid();
        }

        /// <summary>
        /// Checks if date of birth is valid
        /// </summary>
        /// <returns>true if month is valid, false if not</returns>
        private bool DateOfBirthIsValid()
        {
            int day = int.Parse(string.Concat(Egn[0], Egn[1]));
            int month = int.Parse(string.Concat(Egn[2], Egn[3]));
            int year = int.Parse(string.Concat(Egn[4], Egn[5]));

            bool result = false;

            if (months.All(x => x != month))
            {
                month -= 40;
                result = months.Any(x => x == month);
            }
            else if (months.Any(x => x == month))
            {
                result = true;
            }

            return result;
        }

        /// <summary>
        /// Checks if region is valid and exists
        /// </summary>
        /// <returns>true if valid and exists, false if not</returns>
        private bool RegionIsValid()
        {
            int seventhAndEight = int.Parse(string.Concat(Egn[6], Egn[7]));

            foreach (var range in regions.Values)
            {
                if (range.Any(x => x == seventhAndEight))
                {
                    return true;
                }
            }

            return false;

        }

        /// <summary>
        /// Checks if last digit is valid according to algorithm
        /// </summary>
        /// <returns>true if valid, false if not</returns>
        private bool TenthDigitIsValid()
        {
            int[] multiplication = new int[9]
            {
                int.Parse(Egn[0].ToString()) * weights[0],
                int.Parse(Egn[1].ToString()) * weights[1],
                int.Parse(Egn[2].ToString()) * weights[2],
                int.Parse(Egn[3].ToString()) * weights[3],
                int.Parse(Egn[4].ToString()) * weights[4],
                int.Parse(Egn[5].ToString()) * weights[5],
                int.Parse(Egn[6].ToString()) * weights[6],
                int.Parse(Egn[7].ToString()) * weights[7],
                int.Parse(Egn[8].ToString()) * weights[8]
            };

            int digitToCheck = int.Parse(Egn[9].ToString());

            int sum = multiplication.Sum();
            int remainder = sum % 11;

            if (remainder < 10 && digitToCheck == remainder)
            {
                return true;
            }
            else if (remainder >= 10 && digitToCheck == 0)
            {
                return true;
            }

            return false;
        }

        private int[] months = new int[] { 01, 02, 03, 04, 05, 06, 07, 08, 09, 10, 11, 12 };
        private int[] weights = new int[] { 2, 4, 8, 5, 10, 9, 7, 3, 6 };
    }
}
