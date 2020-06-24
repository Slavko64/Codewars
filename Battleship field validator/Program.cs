using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship_field_validator
{
    public class BattleshipField
    {
        static int n = 10;
        static int[] ShipsCount = new int[4];
        public static bool HorizontalShips(ref int[,] field)
        {
            int ShipLength = 0;
            for (int i = 0; i < n; i++)
            {
                ShipLength = 0;
                for (int j = 0; j < n; j++)
                {
                    if (ShipLength > 4)
                        return false;
                    if (field[i, j] == 1)
                        ShipLength++;
                    else if ((field[i, j] == 0 || j == n - 1))
                    {
                        if (ShipLength > 1)
                        {
                            ShipsCount[ShipLength - 1]++;
                            for (int k = 1; k <= ShipLength; k++)
                            {
                                field[i, j - k] = 0;
                            }
                            if (i - 1 > 0)
                                for (int k = 1; k <= ShipLength; k++)
                                    if (field[i - 1, j - k] == 1) return false;
                            if (i + 1 < n)
                                for (int k = 1; k <= ShipLength; k++)
                                    if (field[i + 1, j - k] == 1) return false;
                            if (j - ShipLength - 1 > 0 && i - 1 > 0)
                                if (field[i - 1, j - ShipLength - 1] == 1) return false;
                            if (j - ShipLength - 1 > 0 && i + 1 < n)
                                if (field[i + 1, j - ShipLength - 1] == 1) return false;
                            if (j < n && i - 1 > 0)
                                if (field[i - 1, j] == 1) return false;
                            if (j < n && i + 1 < n)
                                if (field[i + 1, j] == 1) return false;
                        }
                        ShipLength = 0;
                    }
                }
            }
            return true;
        }
        public static bool VerticalShips(ref int[,] field)
        {
            int ShipLength;
            for (int j = 0; j < n; j++)
            {
                ShipLength = 0;
                for (int i = 0; i < n; i++)
                {
                    if (ShipLength > 4)
                        return false;
                    if (field[i, j] == 1)
                        ShipLength++;
                    else if ((field[i, j] == 0 || j == n - 1))
                    {
                        if (ShipLength > 1)
                        {
                            ShipsCount[ShipLength - 1]++;
                            for (int k = 1; k <= ShipLength; k++)
                            {
                                field[i - k, j] = 0;
                            }
                            if (j - 1 > 0)
                                for (int k = 1; k <= ShipLength; k++)
                                    if (field[i - k, j - 1] == 1)
                                        return false;
                            if (j + 1 < n)
                                for (int k = 1; k <= ShipLength; k++)
                                    if (field[i - k, j + 1] == 1)
                                        return false;
                            if (i - ShipLength - 1 > 0 && j - 1 > 0)
                                if (field[i - ShipLength - 1, j - 1] == 1)
                                    return false;
                            if (i - ShipLength - 1 > 0 && j + 1 < n)
                                if (field[i - ShipLength - 1, j + 1] == 1)
                                    return false;
                            if (i < n && j - 1 > 0)
                                if (field[i, j - 1] == 1)
                                    return false;
                            if (i < n && j + 1 < n)
                                if (field[i, j + 1] == 1)
                                    return false;
                        }
                        ShipLength = 0;
                    }
                }
            }
            return true;
        }
        public static bool SingleShips(ref int[,] field)
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (field[i, j] == 1)
                        ShipsCount[0]++;
            if (ShipsCount[0] != 4 || ShipsCount[1] != 3 || ShipsCount[2] != 2 || ShipsCount[3] != 1)
                return false;
            return true;
        }
            public static bool ValidateBattlefield(int[,] field)
        {
            if (HorizontalShips(ref field) == false || VerticalShips(ref field) == false || SingleShips(ref field) == false)
                return false;
            return true;
        }
    }
        class Program
        {

            static void Main(string[] args)
            {
                int[,] field = new int[10, 10]
                     {{1, 0, 0, 0, 0, 1, 1, 0, 0, 0},
                      {1, 0, 1, 0, 0, 0, 0, 0, 1, 0},
                      {1, 0, 1, 0, 1, 1, 1, 0, 1, 0},
                      {1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                      {0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
                      {0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
                      {0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
                      {0, 0, 0, 1, 0, 0, 0, 0, 0, 0},
                      {0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
                      {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}};
                BattleshipField.ValidateBattlefield(field);
            }
        }
    }
