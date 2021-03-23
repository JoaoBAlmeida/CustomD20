using System;
using System.Collections.Generic;
using System.Text;

namespace CustomD20.Controllers
{
    public class Rubric
    {
        public Dictionary<int, string> GetRubric(int Pont)
        {
            Dictionary<int, string> rubric;
            if(Pont < 3)
            {
                return rubric = new Dictionary<int, string>
                {
                    {1 , "wine"},
                    {2 , "red"},
                    {3 , "red"},
                    {4 , "red"},
                    {5 , "red"},
                    {6 , "red"},
                    {7 , "red"},
                    {8 , "red"},
                    {9 , "red"},
                    {10, "red"},
                    {11, "red"},
                    {12, "red"},
                    {13, "red"},
                    {14, "red"},
                    {15, "green"},
                    {16, "green" },
                    {17, "green" },
                    {18, "green" },
                    {19, "blue" },
                    {20, "purple" }
                };
            }
            else if(Pont > 2 && Pont < 5)
            {
                return rubric = new Dictionary<int, string>
                {
                    {1, "wine" },
                    {2, "red" },
                    {3, "red" },
                    {4, "red" },
                    {5, "red" },
                    {6, "red" },
                    {7, "red" },
                    {8, "red" },
                    {9, "red" },
                    {10, "red" },
                    {11, "red" },
                    {12, "red" },
                    {13, "red" },
                    {14, "green" },
                    {15, "green" },
                    {16, "green" },
                    {17, "green" },
                    {18, "green" },
                    {19, "blue" },
                    {20, "purple" }
                };
            }
            else if(Pont > 4 && Pont < 7)
            {
                return rubric = new Dictionary<int, string>
                {
                    {1, "wine" },
                    {2, "red" },
                    {3, "red" },
                    {4, "red" },
                    {5, "red" },
                    {6, "red" },
                    {7, "red" },
                    {8, "red" },
                    {9, "red" },
                    {10, "red" },
                    {11, "red" },
                    {12, "red" },
                    {13, "green" },
                    {14, "green" },
                    {15, "green" },
                    {16, "green" },
                    {17, "green" },
                    {18, "blue" },
                    {19, "blue" },
                    {20, "purple" }
                };
            }
            else if(Pont > 6 && Pont < 9)
            {
                return rubric = new Dictionary<int, string>
                {
                    {1, "wine" },
                    {2, "red" },
                    {3, "red" },
                    {4, "red" },
                    {5, "red" },
                    {6, "red" },
                    {7, "red" },
                    {8, "red" },
                    {9, "red" },
                    {10, "red" },
                    {11, "red" },
                    {12, "green" },
                    {13, "green" },
                    {14, "green" },
                    {15, "green" },
                    {16, "green" },
                    {17, "green" },
                    {18, "blue" },
                    {19, "blue" },
                    {20, "purple" }
                };
            }
            else if(Pont > 8 && Pont < 11)
            {
                return rubric = new Dictionary<int, string>
                {
                    {1, "wine" },
                    {2, "red" },
                    {3, "red" },
                    {4, "red" },
                    {5, "red" },
                    {6, "red" },
                    {7, "red" },
                    {8, "red" },
                    {9, "red" },
                    {10, "red" },
                    {11, "green" },
                    {12, "green" },
                    {13, "green" },
                    {14, "green" },
                    {15, "green" },
                    {16, "green" },
                    {17, "blue" },
                    {18, "blue" },
                    {19, "blue" },
                    {20, "purple" }
                };
            }
            else if(Pont > 10 && Pont < 13)
            {
                return rubric = new Dictionary<int, string>
                {
                    {1, "wine" },
                    {2, "red" },
                    {3, "red" },
                    {4, "red" },
                    {5, "red" },
                    {6, "red" },
                    {7, "red" },
                    {8, "red" },
                    {9, "red" },
                    {10, "green" },
                    {11, "green" },
                    {12, "green" },
                    {13, "green" },
                    {14, "green" },
                    {15, "green" },
                    {16, "green" },
                    {17, "blue" },
                    {18, "blue" },
                    {19, "blue" },
                    {20, "purple" }
                };
            }
            else if(Pont > 12 && Pont < 15)
            {
                return rubric = new Dictionary<int, string>
                {
                    {1,"wine"  },
                    {2, "red" },
                    {3, "red" },
                    {4, "red" },
                    {5, "red" },
                    {6, "red" },
                    {7, "red" },
                    {8, "red" },
                    {9, "green" },
                    {10, "green" },
                    {11, "green" },
                    {12, "green" },
                    {13, "green" },
                    {14, "green" },
                    {15, "green" },
                    {16, "blue" },
                    {17, "blue" },
                    {18, "blue" },
                    {19, "blue" },
                    {20, "purple" }
                };
            }
            else if(Pont > 14 && Pont < 17)
            {
                return rubric = new Dictionary<int, string>
                {
                    {1, "wine" },
                    {2, "red" },
                    {3, "red" },
                    {4, "red" },
                    {5, "red" },
                    {6, "red" },
                    {7, "red" },
                    {8, "green" },
                    {9, "green" },
                    {10, "green" },
                    {11, "green" },
                    {12, "green" },
                    {13, "green" },
                    {14, "green" },
                    {15, "green" },
                    {16, "blue" },
                    {17, "blue" },
                    {18, "blue" },
                    {19, "blue" },
                    {20, "purple" }
                };
            }
            else if(Pont > 16 && Pont < 19)
            {
                return rubric = new Dictionary<int, string>
                {
                    {1, "wine" },
                    {2, "red" },
                    {3, "red" },
                    {4, "red" },
                    {5, "red" },
                    {6, "red" },
                    {7, "green" },
                    {8, "green" },
                    {9, "green" },
                    {10, "green" },
                    {11, "green" },
                    {12, "green" },
                    {13, "green" },
                    {14, "green" },
                    {15, "blue" },
                    {16, "blue" },
                    {17, "blue" },
                    {18, "blue" },
                    {19, "blue" },
                    {20, "purple" }
                };
            }
            else if(Pont == 19)
            {
                return rubric = new Dictionary<int, string>
                {
                    {1, "wine" },
                    {2, "red" },
                    {3, "red" },
                    {4, "red" },
                    {5, "green" },
                    {6, "green" },
                    {7, "green" },
                    {8, "green" },
                    {9, "green" },
                    {10, "green" },
                    {11, "green" },
                    {12, "green" },
                    {13, "blue" },
                    {14, "blue" },
                    {15, "blue" },
                    {16, "blue" },
                    {17, "blue" },
                    {18, "blue" },
                    {19, "purple" },
                    {20, "purple" }
                };
            }
            else
            {
                return rubric = new Dictionary<int, string>
                {
                    {1, "wine" },
                    {2, "red" },
                    {3, "red" },
                    {4, "green" },
                    {5, "green" },
                    {6, "green" },
                    {7, "green" },
                    {8, "green" },
                    {9, "green" },
                    {10, "green" },
                    {11, "blue" },
                    {12, "blue" },
                    {13, "blue" },
                    {14, "blue" },
                    {15, "blue" },
                    {16, "blue" },
                    {17, "blue" },
                    {18, "purple" },
                    {19, "purple" },
                    {20, "purple" }
                };
            }
        }

        public String GetEvaluation(string Color)
        {
            Dictionary<string, string> Evaluation = new Dictionary<string, string>
            {
                {"wine", "Desastre" },
                {"red", "Falha" },
                {"green", "Sucesso Normal" },
                {"blue", "Sucesso Bom" },
                {"purple", "Sucesso Extremo" }
            };

            return Evaluation[Color];
        }
    }
}
