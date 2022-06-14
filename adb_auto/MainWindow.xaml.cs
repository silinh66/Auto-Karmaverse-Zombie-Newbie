using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using KAutoHelper;
using Color = System.Drawing.Color;

namespace adb_auto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region data
        Bitmap BOMB_BMP;
        Bitmap BIG_BOMB_BMP;
        Bitmap WIN_BMP;
        Bitmap LEVEL_UP_BMP;
        Bitmap STAGE1_BMP;
        Bitmap STAGE2_BMP;
        Bitmap UPGRADE_BUILDING_BMP;
        Bitmap PLUS_BMP;
        Bitmap PYRO_BMP;
        Bitmap BUILDING_RIGHT_YELLOW_CAR_BMP;
        Bitmap PLUS_COLLECT_BMP;
        Bitmap PLUS_COLLECT_2_BMP;
        Bitmap BUILD_FARM_1_BMP;
        Bitmap BUILD_FARM_2_BMP;
        Bitmap PLUS_COLLECT_3_BMP;
        Bitmap BUILD_FARM_3_BMP;
        Bitmap UPGRADE_ROCK_BMP;
        Bitmap BUILD_FARM_4_BMP;
        Bitmap PLUS_COLLECT_4_BMP;
        Bitmap TOMATO_BMP;
        Bitmap BUILD_FARM_5_BMP;
        Bitmap EXIT_BMP;
        Bitmap ROCK_BMP;
        Bitmap SCHOOL_BMP;
        Bitmap GREEN_UPGRADE_ICON_BMP;
        Bitmap BLUE_BMP;
        Bitmap RED_BMP;
        Bitmap YELLOW_BMP;
        Bitmap GREEN_BMP;
        Bitmap PURPLE_BMP;
        Bitmap BOMB_BLUE_BMP;
        Bitmap BOMB_YELLOW_BMP;
        Bitmap BIG_BOMB_YELLOW_BMP;
        #endregion

        int delayShort = 50, delayLong = 500;
        public MainWindow()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            BOMB_BMP = (Bitmap)Bitmap.FromFile("Data/bomb.png");
            BIG_BOMB_BMP = (Bitmap)Bitmap.FromFile("Data/big_bomb.png");
            WIN_BMP = (Bitmap)Bitmap.FromFile("Data/win.png");
            LEVEL_UP_BMP = (Bitmap)Bitmap.FromFile("Data/level_up.png");
            STAGE1_BMP = (Bitmap)Bitmap.FromFile("Data/stage1.png");
            STAGE2_BMP = (Bitmap)Bitmap.FromFile("Data/stage2.png");
            UPGRADE_BUILDING_BMP = (Bitmap)Bitmap.FromFile("Data/upgrade_building.png");
            PLUS_BMP = (Bitmap)Bitmap.FromFile("Data/plus.png");
            PYRO_BMP = (Bitmap)Bitmap.FromFile("Data/pyro.png");
            BUILDING_RIGHT_YELLOW_CAR_BMP = (Bitmap)Bitmap.FromFile("Data/buildingRightYellowCar.png");
            PLUS_COLLECT_BMP = (Bitmap)Bitmap.FromFile("Data/plus_collect.png");
            PLUS_COLLECT_2_BMP = (Bitmap)Bitmap.FromFile("Data/plus_collect_2.png");
            BUILD_FARM_1_BMP = (Bitmap)Bitmap.FromFile("Data/build_farm_1.png");
            BUILD_FARM_2_BMP = (Bitmap)Bitmap.FromFile("Data/build_farm_2.png");
            PLUS_COLLECT_3_BMP = (Bitmap)Bitmap.FromFile("Data/plus_collect_3.png");
            BUILD_FARM_3_BMP = (Bitmap)Bitmap.FromFile("Data/build_farm_3.png");
            UPGRADE_ROCK_BMP = (Bitmap)Bitmap.FromFile("Data/upgrade_rock.png");
            BUILD_FARM_4_BMP = (Bitmap)Bitmap.FromFile("Data/build_farm_4.png");
            PLUS_COLLECT_4_BMP = (Bitmap)Bitmap.FromFile("Data/plus_collect_4.png");
            TOMATO_BMP = (Bitmap)Bitmap.FromFile("Data/tomato.png");
            BUILD_FARM_5_BMP = (Bitmap)Bitmap.FromFile("Data/build_farm_5.png");
            EXIT_BMP = (Bitmap)Bitmap.FromFile("Data/exit.png");
            ROCK_BMP = (Bitmap)Bitmap.FromFile("Data/rock.png");
            SCHOOL_BMP = (Bitmap)Bitmap.FromFile("Data/school.png");
            GREEN_UPGRADE_ICON_BMP = (Bitmap)Bitmap.FromFile("Data/green_upgrade_icon.png");
            BLUE_BMP = (Bitmap)Bitmap.FromFile("Data/blue.png");
            RED_BMP = (Bitmap)Bitmap.FromFile("Data/red.png");
            YELLOW_BMP = (Bitmap)Bitmap.FromFile("Data/yellow.png");
            GREEN_BMP = (Bitmap)Bitmap.FromFile("Data/green.png");
            PURPLE_BMP = (Bitmap)Bitmap.FromFile("Data/purple.png");
            BOMB_BLUE_BMP = (Bitmap)Bitmap.FromFile("Data/bomb_blue.png");
            BOMB_YELLOW_BMP = (Bitmap)Bitmap.FromFile("Data/bomb_yellow.png");
            BIG_BOMB_YELLOW_BMP = (Bitmap)Bitmap.FromFile("Data/big_bomb_yellow.png");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Task t = new Task(() =>
            {
                isStop = false;
                Auto();
            });
            t.Start();
        }


        bool isStop = false;
        string[,] IntArray = new string[7, 5];

        bool ColorsAreClose(Color a, Color z, int threshold = 20)
        {
            int r = (int)a.R - z.R,
                g = (int)a.G - z.G,
                b = (int)a.B - z.B;
            return (r * r + g * g + b * b) <= threshold * threshold;
        }

        void scanBoard(string deviceID)
        {
            var screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
            //var bluePoints = KAutoHelper.ImageScanOpenCV.FindOutPoints(screen, BLUE_BMP);
            //var redPoints = KAutoHelper.ImageScanOpenCV.FindOutPoints(screen, RED_BMP);
            //var yellowPoints = KAutoHelper.ImageScanOpenCV.FindOutPoints(screen, YELLOW_BMP);
            //var greenPoints = KAutoHelper.ImageScanOpenCV.FindOutPoints(screen, GREEN_BMP);
            //var purplePoints = KAutoHelper.ImageScanOpenCV.FindOutPoints(screen, PURPLE_BMP);
            //var bomBluePoints = KAutoHelper.ImageScanOpenCV.FindOutPoints(screen, BOMB_BLUE_BMP);
            //var bomYellowPoints = KAutoHelper.ImageScanOpenCV.FindOutPoints(screen, BOMB_YELLOW_BMP);
            //var bigBombYellowPoints = KAutoHelper.ImageScanOpenCV.FindOutPoints(screen, BIG_BOMB_YELLOW_BMP);
            //yellow 255 255 239 198 
            //blue 255 62 218 247
            //green 255 147 232 71
            //red 255 249 79 79
            //purple 255 243 134 243
            Color yellow = Color.FromArgb(255, 239, 198);
            Color yellow2 = Color.FromArgb(248, 205, 61);
            Color blue = Color.FromArgb(62, 199, 249);
            Color blue2 = Color.FromArgb(72, 166, 197);
            Color blue3 = Color.FromArgb(56, 213, 246);
            Color blue4 = Color.FromArgb(89, 140, 171);
            Color blue5 = Color.FromArgb(44, 200, 233);
            Color blue6 = Color.FromArgb(50, 207, 240);
            Color blue7 = Color.FromArgb(52, 150, 193);
            Color green = Color.FromArgb(147, 232, 71);
            Color green2 = Color.FromArgb(147, 232, 71);
            Color red = Color.FromArgb(249, 79, 79);
            Color red2 = Color.FromArgb(223, 151, 151);
            Color red3 = Color.FromArgb(247, 210, 210);
            Color red4 = Color.FromArgb(230, 84, 84);
            Color red5 = Color.FromArgb(239, 77, 78);
            Color red6 = Color.FromArgb(225, 176, 176);
            Color purple = Color.FromArgb(243, 134, 243);
            Color purple2 = Color.FromArgb(243, 134, 243);
            //Color pixcelColor = screen.GetPixel(1 * 100 + 60, 4 * 100 + 510);
            //System.Diagnostics.Debug.WriteLine(pixcelColor);
            //System.Diagnostics.Debug.WriteLine(ColorsAreClose(pixcelColor, red5));




            //(60, 510); (160, 510); (260, 510); (360; 510); (460; 510); (560; 510); (660; 510); 
            //(60, 610); (160, 610); (260, 610); (360; 610); (460; 610); (560; 610); (660; 610); 
            //(60, 710); (160, 710); (260, 710); (360; 710); (460; 710); (560; 710); (660; 710); 
            //(60, 810); (160, 810); (260, 810); (360; 810); (460; 810); (560; 810); (660; 810); 
            //(60, 910); (160, 910); (260, 910); (360; 910); (460; 910); (560; 910); (660; 910); 

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Color pixcelColor = screen.GetPixel(i * 100 + 60, j * 100 + 510);
                    if (ColorsAreClose(pixcelColor, yellow) || ColorsAreClose(pixcelColor, yellow2))
                    {
                        IntArray[i, j] = "yellow";
                        continue;
                    }
                    if (ColorsAreClose(pixcelColor, blue) || ColorsAreClose(pixcelColor, blue2) || ColorsAreClose(pixcelColor, blue3) || ColorsAreClose(pixcelColor, blue4) || ColorsAreClose(pixcelColor, blue5) || ColorsAreClose(pixcelColor, blue6) || ColorsAreClose(pixcelColor, blue7))
                    {
                        IntArray[i, j] = "blue";
                        continue;
                    }
                    if (ColorsAreClose(pixcelColor, green) || ColorsAreClose(pixcelColor, green2))
                    {
                        IntArray[i, j] = "green";
                        continue;
                    }
                    if (ColorsAreClose(pixcelColor, red) || ColorsAreClose(pixcelColor, red2) || ColorsAreClose(pixcelColor, red3) || ColorsAreClose(pixcelColor, red4) || ColorsAreClose(pixcelColor, red5) || ColorsAreClose(pixcelColor, red6))
                    {
                        IntArray[i, j] = "red";
                        continue;
                    }
                    if (ColorsAreClose(pixcelColor, purple) || ColorsAreClose(pixcelColor, purple2))
                    {
                        IntArray[i, j] = "purple";
                        continue;
                    }

                    //System.Diagnostics.Debug.WriteLine(pixcelColor);
                    //System.Diagnostics.Debug.WriteLine(ColorsAreClose(pixcelColor, blue));
                }
            }
        }

        int count = 0;

        void playSwap(string deviceID)
        {
            try
            {
                 //--------------------------NEW----------------------------
            int delay = 100;
            scanBoard(deviceID);
            //bool boardIsMoving = isBoardMoving();
            //while(boardIsMoving)
            //{
            //    scanBoard(deviceID);
            //    boardIsMoving = isBoardMoving();
            //}

            //System.Diagnostics.Debug.WriteLine("-------------Result--------------");
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 7; j++)
            //    {
            //        System.Diagnostics.Debug.Write(IntArray[j, i] + " ");
            //    }
            //    System.Diagnostics.Debug.WriteLine("\n");
            //}

            if (count == 5)
            {
                //Click character 1
                KAutoHelper.ADBHelper.Tap(deviceID, 66, 1081);
                Delay(delay);
                if (isStop)
                    return;
                //Click character 2
                KAutoHelper.ADBHelper.Tap(deviceID, 211, 1088);
                Delay(delay);
                if (isStop)
                    return;
                //Click character 3
                KAutoHelper.ADBHelper.Tap(deviceID, 351, 1085);
                Delay(delay);
                if (isStop)
                    return;
                //Click character 4
                KAutoHelper.ADBHelper.Tap(deviceID, 491, 1088);
                Delay(delay);
                if (isStop)
                    return;
                //Click character 5
                KAutoHelper.ADBHelper.Tap(deviceID, 638, 1083);
                Delay(delay);
                if (isStop)
                    return;
                var screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
                var bigBombPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, BIG_BOMB_BMP);
                var bombPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, BOMB_BMP);
                    var winPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, WIN_BMP);
                    var plusPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, PLUS_BMP);
                    if (plusPoint != null)
                    {
                        return;
                    }
                    if (winPoint != null)
                    {
                        return;
                    }
                    if (bigBombPoint != null)
                {
                    KAutoHelper.ADBHelper.Tap(deviceID, bigBombPoint.Value.X, bigBombPoint.Value.Y);
                    Delay(delay);
                    if (isStop)
                        return;
                }
                if (bombPoint != null)
                {
                    KAutoHelper.ADBHelper.Tap(deviceID, bombPoint.Value.X, bombPoint.Value.Y);
                    Delay(delay);
                    if (isStop)
                        return;
                }
                count = 0;
            }




            //oneTwo: blue blue green
            //oneThree: blue green blue
            //twoThree: green blue blue
            int moveFromX = -1, moveFromY = -1, moveToX = -1, moveToY = -1;
            //int preMoveFromX = moveFromX, preMoveFromY = moveFromY, preMoveToX = moveToX, preMoveToY = moveToY;
                for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (j < 5)
                    {
                        bool oneTwoX = IntArray[j, i] == IntArray[j + 1, i];
                        bool oneThreeX = IntArray[j, i] == IntArray[j + 2, i];
                        bool twoThreeX = IntArray[j + 1, i] == IntArray[j + 2, i];
                        if (oneTwoX)
                        {
                            if (j != 4) //Not last column
                            {
                                //check move horizontal to right
                                if (IntArray[j, i] == IntArray[j + 3, i])
                                {
                                    moveFromX = j + 2;
                                    moveFromY = i;
                                    moveToX = j + 3;
                                    moveToY = i;
                                    break;
                                }
                            }
                            if (i != 4) //Not last row
                            {
                                //check move vertical to down
                                if (IntArray[j, i] == IntArray[j + 2, i + 1])
                                {
                                    moveFromX = j + 2;
                                    moveFromY = i;
                                    moveToX = j + 2;
                                    moveToY = i + 1;
                                    break;
                                }
                            }
                            if (i != 0) //Not first row
                            {
                                //check move vertical to up
                                if (IntArray[j, i] == IntArray[j + 2, i - 1])
                                {
                                    moveFromX = j + 2;
                                    moveFromY = i;
                                    moveToX = j + 2;
                                    moveToY = i - 1;
                                    break;
                                }
                            }
                        }
                        else if (oneThreeX)
                        {
                            if (i != 4) //Not last row
                            {
                                //check move vertical to down
                                if (IntArray[j, i] == IntArray[j + 1, i + 1])
                                {
                                    moveFromX = j + 1;
                                    moveFromY = i;
                                    moveToX = j + 1;
                                    moveToY = i + 1;
                                    break;
                                }
                            }
                            if (i != 0) //Not first row
                            {
                                //check move vertical to up
                                if (IntArray[j, i] == IntArray[j + 1, i - 1])
                                {
                                    moveFromX = j + 1;
                                    moveFromY = i;
                                    moveToX = j + 1;
                                    moveToY = i - 1;
                                    break;
                                }
                            }
                        }
                        else if (twoThreeX)
                        {
                            if (j != 0) //not first column
                            {
                                //check move horizontal to left
                                if (IntArray[j + 1, i] == IntArray[j - 1, i])
                                {
                                    moveFromX = j;
                                    moveFromY = i;
                                    moveToX = j - 1;
                                    moveToY = i;
                                    break;
                                }
                            }
                            if (i != 4) //Not last row
                            {
                                //check move vertical to down
                                if (IntArray[j + 1, i] == IntArray[j, i + 1])
                                {
                                    moveFromX = j;
                                    moveFromY = i;
                                    moveToX = j;
                                    moveToY = i + 1;
                                    break;
                                }
                            }
                            if (i != 0) //Not first row
                            {
                                //check move vertical to up
                                if (IntArray[j + 1, i] == IntArray[j, i - 1])
                                {
                                    moveFromX = j;
                                    moveFromY = i;
                                    moveToX = j;
                                    moveToY = i - 1;
                                    break;
                                }
                            }
                        }
                    }

                    if (i < 3)
                    {
                        bool oneTwoY = IntArray[j, i] == IntArray[j, i + 1];
                        bool oneThreeY = IntArray[j, i] == IntArray[j, i + 2];
                        bool twoThreeY = IntArray[j, i + 1] == IntArray[j, i + 2];
                        if (oneTwoY)
                        {
                            if (i != 2) //Not last row
                            {
                                //check move vertical down
                                if (IntArray[j, i] == IntArray[j, i + 3])
                                {
                                    moveFromX = j;
                                    moveFromY = i + 2;
                                    moveToX = j;
                                    moveToY = i + 3;
                                    break;
                                }
                            }
                            if (j != 6) //Not last column
                            {
                                //check move horizontal to right
                                if (IntArray[j, i] == IntArray[j + 1, i + 2])
                                {
                                    moveFromX = j;
                                    moveFromY = i + 2;
                                    moveToX = j + 1;
                                    moveToY = i + 2;
                                    break;
                                }
                            }
                            if (j != 0) //Not first column
                            {
                                //check move horizontal to left
                                if (IntArray[j, i] == IntArray[j - 1, i + 2])
                                {
                                    moveFromX = j;
                                    moveFromY = i + 2;
                                    moveToX = j - 1;
                                    moveToY = i + 2;
                                    break;
                                }
                            }
                        }
                        else if (oneThreeY)
                        {
                            if (j != 6) //Not last column
                            {
                                //check move horizontal to right
                                if (IntArray[j, i] == IntArray[j + 1, i + 1])
                                {
                                    moveFromX = j;
                                    moveFromY = i + 1;
                                    moveToX = j + 1;
                                    moveToY = i + 1;
                                    break;
                                }
                            }
                            if (j != 0) //Not first column
                            {
                                //check move horizontal to left
                                if (IntArray[j, i] == IntArray[j - 1, i + 1])
                                {
                                    moveFromX = j;
                                    moveFromY = i + 1;
                                    moveToX = j - 1;
                                    moveToY = i + 1;
                                    break;
                                }
                            }
                        }
                        else if (twoThreeY)
                        {
                            if (i != 0) //Not first row
                            {
                                //check move vertical down
                                if (IntArray[j, i + 1] == IntArray[j, i - 1])
                                {
                                    moveFromX = j;
                                    moveFromY = i;
                                    moveToX = j;
                                    moveToY = i - 1;
                                    break;
                                }
                            }
                            if (j != 6) //Not last column
                            {
                                //check move horizontal to right
                                if (IntArray[j, i + 1] == IntArray[j + 1, i])
                                {
                                    moveFromX = j;
                                    moveFromY = i;
                                    moveToX = j + 1;
                                    moveToY = i;
                                    break;
                                }
                            }
                            if (j != 0) //Not first column
                            {
                                //check move horizontal to left
                                if (IntArray[j, i + 1] == IntArray[j - 1, i])
                                {
                                    moveFromX = j;
                                    moveFromY = i;
                                    moveToX = j - 1;
                                    moveToY = i;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
                //if (preMoveFromX == moveFromX && preMoveFromY == moveFromY && preMoveToX == moveToX && preMoveToY == moveToY)
                //{
                //    Delay(1000);
                //    scanBoard(deviceID);
                //}
                //preMoveFromX = moveFromX;
                //preMoveFromY = moveFromY;
                //preMoveToX = moveToX;
                //preMoveToY = moveToY;
                //System.Diagnostics.Debug.Write("----MOVE FROM (" + moveFromX + "," + moveFromY + ") TO (" + moveToX + "," + moveToY + ")---------");
                KAutoHelper.ADBHelper.Swipe(deviceID, moveFromX * 100 + 50, moveFromY * 100 + 550, moveToX * 100 + 50, moveToY * 100 + 550);
            count++;
            }
            catch (Exception)
            {
                return;
                throw;
            }
           
            








            //-------------------------Old------------------------------
            //int aX = 55, aY = 541, delta = 100, delay = 100;
            ////swipe horizontal(left to right)
            //for (int i = 1; i < 6; i++)
            //{
            //    for (int j = 0; j < 6; j++)
            //    {
            //        KAutoHelper.ADBHelper.Swipe(deviceID, aX + j * delta, aY, aX + (j + 1) * delta, aY);
            //        Delay(delay);
            //        if (isStop)
            //            return;
            //    }
            //    aY = 541 + i * delta;
            //}
            //aY = 541;
            //Delay(2000);
            ////Click character 1
            //KAutoHelper.ADBHelper.Tap(deviceID, 66, 1081);
            //Delay(delay);
            //if (isStop)
            //    return;
            ////Click character 2
            //KAutoHelper.ADBHelper.Tap(deviceID, 211, 1088);
            //Delay(delay);
            //if (isStop)
            //    return;
            ////Click character 3
            //KAutoHelper.ADBHelper.Tap(deviceID, 351, 1085);
            //Delay(delay);
            //if (isStop)
            //    return;
            ////Click character 4
            //KAutoHelper.ADBHelper.Tap(deviceID, 491, 1088);
            //Delay(delay);
            //if (isStop)
            //    return;
            ////Click character 5
            //KAutoHelper.ADBHelper.Tap(deviceID, 638, 1083);
            //Delay(delay);
            //if (isStop)
            //    return;
            //var screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
            //var bigBombPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, BIG_BOMB_BMP, 0.7);
            //var bombPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, BOMB_BMP);
            //if (bigBombPoint != null)
            //{
            //    KAutoHelper.ADBHelper.Tap(deviceID, bigBombPoint.Value.X, bigBombPoint.Value.Y);
            //    Delay(delay);
            //    if (isStop)
            //        return;
            //}
            //if (bombPoint != null)
            //{
            //    KAutoHelper.ADBHelper.Tap(deviceID, bombPoint.Value.X, bombPoint.Value.Y);
            //    Delay(delay);
            //    if (isStop)
            //        return;
            //}
            //screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
            //var winPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, WIN_BMP);
            //var plusPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, PLUS_BMP);
            //if (plusPoint != null)
            //{
            //    return;
            //}
            //if (winPoint != null)
            //{
            //    return;
            //}
            ////swipe vertical (up to down)
            //for (int k = 1; k < 8; k++)
            //{
            //    for (int l = 0; l < 4; l++)
            //    {
            //        KAutoHelper.ADBHelper.Swipe(deviceID, aX, aY + l * delta, aX, aY + (l + 1) * delta);
            //        Delay(delay);
            //        if (isStop)
            //            return;
            //    }
            //    aX = 55 + k * delta;
            //}
            //aX = 655;
            //aY = 541;
            //Delay(2000);
            ////Click character 1
            //KAutoHelper.ADBHelper.Tap(deviceID, 66, 1081);
            //Delay(delay);
            //if (isStop)
            //    return;
            ////Click character 2
            //KAutoHelper.ADBHelper.Tap(deviceID, 211, 1088);
            //Delay(delay);
            //if (isStop)
            //    return;
            ////Click character 3
            //KAutoHelper.ADBHelper.Tap(deviceID, 351, 1085);
            //Delay(delay);
            //if (isStop)
            //    return;
            ////Click character 4
            //KAutoHelper.ADBHelper.Tap(deviceID, 491, 1088);
            //Delay(delay);
            //if (isStop)
            //    return;
            ////Click character 5
            //KAutoHelper.ADBHelper.Tap(deviceID, 638, 1083);
            //Delay(delay);
            //if (isStop)
            //    return;
            //screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
            //bigBombPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, BIG_BOMB_BMP, 0.7);
            //bombPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, BOMB_BMP);
            //if (bigBombPoint != null)
            //{
            //    KAutoHelper.ADBHelper.Tap(deviceID, bigBombPoint.Value.X, bigBombPoint.Value.Y);
            //    Delay(delay);
            //    if (isStop)
            //        return;
            //}
            //if (bombPoint != null)
            //{
            //    KAutoHelper.ADBHelper.Tap(deviceID, bombPoint.Value.X, bombPoint.Value.Y);
            //    Delay(delay);
            //    if (isStop)
            //        return;
            //}
            //screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
            //winPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, WIN_BMP);
            //plusPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, PLUS_BMP);
            //if (plusPoint != null)
            //{
            //    return;
            //}
            //if (winPoint != null)
            //{
            //    return;
            //}
            ////swipe horizontal (right to left)
            //for (int i = 1; i < 6; i++)
            //{
            //    for (int j = 0; j < 6; j++)
            //    {
            //        KAutoHelper.ADBHelper.Swipe(deviceID, aX - j * delta, aY, aX - (j + 1) * delta, aY);
            //        Delay(delay);
            //        if (isStop)
            //            return;
            //    }
            //    aY = 541 + i * delta;
            //}
            //aX = 55;
            //aY = 541;
            //Delay(2000);
            ////Click character 1
            //KAutoHelper.ADBHelper.Tap(deviceID, 66, 1081);
            //Delay(delay);
            //if (isStop)
            //    return;
            ////Click character 2
            //KAutoHelper.ADBHelper.Tap(deviceID, 211, 1088);
            //Delay(delay);
            //if (isStop)
            //    return;
            ////Click character 3
            //KAutoHelper.ADBHelper.Tap(deviceID, 351, 1085);
            //Delay(delay);
            //if (isStop)
            //    return;
            ////Click character 4
            //KAutoHelper.ADBHelper.Tap(deviceID, 491, 1088);
            //Delay(delay);
            //if (isStop)
            //    return;
            ////Click character 5
            //KAutoHelper.ADBHelper.Tap(deviceID, 638, 1083);
            //Delay(delay);
            //if (isStop)
            //    return;
            //screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
            //bigBombPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, BIG_BOMB_BMP, 0.7);
            //bombPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, BOMB_BMP);
            //if (bigBombPoint != null)
            //{
            //    KAutoHelper.ADBHelper.Tap(deviceID, bigBombPoint.Value.X, bigBombPoint.Value.Y);
            //    Delay(delay);
            //    if (isStop)
            //        return;
            //}
            //if (bombPoint != null)
            //{
            //    KAutoHelper.ADBHelper.Tap(deviceID, bombPoint.Value.X, bombPoint.Value.Y);
            //    Delay(delay);
            //    if (isStop)
            //        return;
            //}
            //screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
            //winPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, WIN_BMP);
            //plusPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, PLUS_BMP);
            //if (plusPoint != null)
            //{
            //    return;
            //}
            //if (winPoint != null)
            //{
            //    return;
            //}
            ////swipe vertical (up to down)
            //for (int k = 1; k < 8; k++)
            //{
            //    for (int l = 0; l < 4; l++)
            //    {
            //        KAutoHelper.ADBHelper.Swipe(deviceID, aX, aY + l * delta, aX, aY + (l + 1) * delta);
            //        Delay(delay);
            //        if (isStop)
            //            return;
            //    }
            //    aX = 55 + k * delta;
            //}
            //Delay(2000);
            ////Click character 1
            //KAutoHelper.ADBHelper.Tap(deviceID, 66, 1081);
            //Delay(delay);
            //if (isStop)
            //    return;
            ////Click character 2
            //KAutoHelper.ADBHelper.Tap(deviceID, 211, 1088);
            //Delay(delay);
            //if (isStop)
            //    return;
            ////Click character 3
            //KAutoHelper.ADBHelper.Tap(deviceID, 351, 1085);
            //Delay(delay);
            //if (isStop)
            //    return;
            ////Click character 4
            //KAutoHelper.ADBHelper.Tap(deviceID, 491, 1088);
            //Delay(delay);
            //if (isStop)
            //    return;
            ////Click character 5
            //KAutoHelper.ADBHelper.Tap(deviceID, 638, 1083);
            //Delay(delay);
            //if (isStop)
            //    return;
            //screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
            //bigBombPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, BIG_BOMB_BMP, 0.7);
            //bombPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, BOMB_BMP);
            //if (bigBombPoint != null)
            //{
            //    KAutoHelper.ADBHelper.Tap(deviceID, bigBombPoint.Value.X, bigBombPoint.Value.Y);
            //    Delay(delay);
            //    if (isStop)
            //        return;
            //}
            //if (bombPoint != null)
            //{
            //    KAutoHelper.ADBHelper.Tap(deviceID, bombPoint.Value.X, bombPoint.Value.Y);
            //    Delay(delay);
            //    if (isStop)
            //        return;
            //}

        }

        void playNewBie(string deviceID, int stageX, int stageY)
        {
            //Màn 1.x
            KAutoHelper.ADBHelper.Tap(deviceID, stageX, stageY);
            Delay(delayShort);
            if (isStop)
                return;
            //Click next
            KAutoHelper.ADBHelper.Tap(deviceID, 360, 1204);
            Delay(delayShort);
            if (isStop)
                return;
            //Click fight
            KAutoHelper.ADBHelper.Tap(deviceID, 351, 1202);
            Delay(delayLong);
            if (isStop)
                return;
            var screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
            var winPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, WIN_BMP);
            //Chơi đến khi win
            while (winPoint == null)
            {
                playSwap(deviceID);
                screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
                winPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, WIN_BMP);
                if (isStop)
                    return;
            }
            if (winPoint != null)
            {
                KAutoHelper.ADBHelper.Tap(deviceID, 498, 1198);
                Delay(delayLong);
                if (isStop)
                    return;
            }
            //Nếu level up
            screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
            var levelUpPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, LEVEL_UP_BMP);
            if (levelUpPoint != null)
            {
                KAutoHelper.ADBHelper.Tap(deviceID, 353, 1003);
                Delay(delayLong);
                if (isStop)
                    return;
            }
        }

        void clickConversation(string deviceID, int delayTime)
        {
            KAutoHelper.ADBHelper.Tap(deviceID, 405, 1174);
            Delay(delayTime);
            if (isStop)
                return;
        }
        void Auto()
        {
            //Lấy ra danh sách devices để dùng
            List<string> devices = new List<string>();
            devices = KAutoHelper.ADBHelper.GetDevices();

            //Chạy từng device
            foreach (var deviceID in devices)
            {
                //Tạo ra 1 luồng xử lí riêng biệt
                Task t = new Task(() =>
                {
                    //------------------START NEW BIE STAGE---------------

                    //Survivor's shelter ...
                    KAutoHelper.ADBHelper.Tap(deviceID, 370, 647);
                    Delay(5000);
                    if (isStop)
                        return;
                    //Pyro said: There's so many
                    clickConversation(deviceID, delayLong);
                    //Caroline said: I'm nearly out of arrows...
                    clickConversation(deviceID, delayLong);
                    //Pyro said: Last can of gas!...
                    clickConversation(deviceID, delayLong);
                    //Caroline said: Even if we're out of ammo...
                    clickConversation(deviceID, 5000);
                    //Ellen said: There! It's Caroline and the others...
                    clickConversation(deviceID, delayLong);
                    //Matthew said: Let's go help them finish ...
                    clickConversation(deviceID, 2000);
                    //Tap the battle icon to fight ...
                    KAutoHelper.ADBHelper.Tap(deviceID, 450, 548);
                    Delay(5000);
                    if (isStop)
                        return;

                    //Kéo từ trên xuống
                    KAutoHelper.ADBHelper.Swipe(deviceID, 355, 539, 355, 638);
                    Delay(3000);
                    if (isStop)
                        return;
                    //Click bomb
                    KAutoHelper.ADBHelper.Tap(deviceID, 355, 634);
                    Delay(5000);
                    if (isStop)
                        return;

                    //click vào thằng người bên phải trên
                    KAutoHelper.ADBHelper.Tap(deviceID, 610, 249);
                    Delay(delayLong);
                    if (isStop)
                        return;
                    //Click vào thẻ cô gái bên phải dưới
                    KAutoHelper.ADBHelper.Tap(deviceID, 578, 1165);
                    Delay(3000);
                    if (isStop)
                        return;

                    //Kéo từ dưới lên
                    KAutoHelper.ADBHelper.Swipe(deviceID, 61, 837, 61, 740);
                    Delay(5000);
                    if (isStop)
                        return;


                    var screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
                    var upgradeBuildingPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, UPGRADE_BUILDING_BMP);
                    //Chơi đến khi win
                    while (upgradeBuildingPoint == null)
                    {
                        playSwap(deviceID);
                        screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
                        upgradeBuildingPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, UPGRADE_BUILDING_BMP);
                        if (isStop)
                            return;
                    }
                    Delay(1000);
                    if (upgradeBuildingPoint != null)
                    {
                        KAutoHelper.ADBHelper.Tap(deviceID, 355, 571);
                        Delay(3000);
                        if (isStop)
                            return;
                    }
                    //Click vào Metal Storage
                    KAutoHelper.ADBHelper.Tap(deviceID, 191, 569);
                    Delay(5000);
                    if (isStop)
                        return;

                    //Click thu hoạch đá
                    KAutoHelper.ADBHelper.Tap(deviceID, 563, 409);
                    Delay(3000);
                    if (isStop)
                        return;

                    //nói chuyện
                    //Matthew said: Great, now that we ha ve resources ...
                    clickConversation(deviceID, delayLong);
                    //Ellen said: Maybe we can use the school bus ...
                    clickConversation(deviceID, delayLong);
                    //Pyro said: Remember to bring enough oil...
                    clickConversation(deviceID, 5000);
                    //Matthew said: Now, let's fill'er up with gas ...
                    clickConversation(deviceID, 2000);
                    //Click vào icon tool
                    KAutoHelper.ADBHelper.Tap(deviceID, 161, 606);
                    Delay(5000);
                    if (isStop)
                        return;

                    //Click claim
                    KAutoHelper.ADBHelper.Tap(deviceID, 353, 1005);
                    Delay(2000);
                    if (isStop)
                        return;

                    //Nói chuyện
                    //Ellen said: Some new survivors want ...
                    clickConversation(deviceID, delayLong);
                    //Matthrew said: They've never been trained ...
                    clickConversation(deviceID, delayLong);
                    //Ellen said: There's a place we can train near ...
                    clickConversation(deviceID, 5000);
                    //Ellen said: Damn. It's overrun with zombies!
                    clickConversation(deviceID, delayLong);
                    //Matthew said: Then let's clean it up
                    clickConversation(deviceID, 3000);
                    //Click vào icon dao vs súng
                    KAutoHelper.ADBHelper.Tap(deviceID, 429, 144);
                    Delay(5000);
                    if (isStop)
                        return;
                    //Colors affect how much damage you can inflict
                    KAutoHelper.ADBHelper.Tap(deviceID, 351, 692);
                    Delay(delayLong);
                    if (isStop)
                        return;
                    //Kéo từ phải qua trái
                    KAutoHelper.ADBHelper.Swipe(deviceID, 653, 835, 552, 835);
                    Delay(2000);
                    if (isStop)
                        return;
                    //Kéo từ phải qua trái
                    KAutoHelper.ADBHelper.Swipe(deviceID, 256, 742, 157, 742);
                    Delay(delayLong);
                    if (isStop)
                        return;
                    screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
                    var plusPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, PLUS_BMP);
                    //Chơi đến khi win
                    while (plusPoint == null)
                    {
                        playSwap(deviceID);
                        screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
                        plusPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, PLUS_BMP);
                        if (isStop)
                            return;
                    }
                    if (plusPoint != null)
                    {
                        KAutoHelper.ADBHelper.Tap(deviceID, 340, 124);
                        Delay(2000);
                        if (isStop)
                            return;
                        KAutoHelper.ADBHelper.Tap(deviceID, 340, 124);
                        Delay(2000);
                        if (isStop)
                            return;
                    }

                    //Click vào dấu cộng to
                    KAutoHelper.ADBHelper.Tap(deviceID, 113, 569);
                    Delay(2000);
                    if (isStop)
                        return;
                    //Click vào thằng Pyro
                    screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
                    var pyroPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, PYRO_BMP);
                    if (pyroPoint != null)
                    {
                        KAutoHelper.ADBHelper.Tap(deviceID, pyroPoint.Value.X, pyroPoint.Value.Y);
                        Delay(2000);
                        if (isStop)
                            return;
                    }
                    //Click begin prroduction
                    KAutoHelper.ADBHelper.Tap(deviceID, 554, 398);
                    Delay(1000);
                    if (isStop)
                        return;
                    //Click produce
                    KAutoHelper.ADBHelper.Tap(deviceID, 478, 373);
                    Delay(1000);
                    if (isStop)
                        return;
                    //Click produce tiếp
                    KAutoHelper.ADBHelper.Tap(deviceID, 351, 1003);
                    Delay(2000);
                    if (isStop)
                        return;
                    //Click claim
                    KAutoHelper.ADBHelper.Tap(deviceID, 357, 824);
                    Delay(1000);
                    if (isStop)
                        return;
                    //Click x đỏ
                    KAutoHelper.ADBHelper.Tap(deviceID, 673, 116);
                    Delay(1000);
                    if (isStop)
                        return;
                    //Click fighterrs
                    KAutoHelper.ADBHelper.Tap(deviceID, 189, 1219);
                    Delay(1000);
                    if (isStop)
                        return;
                    //Click thằng bên trái ngoài cùng
                    KAutoHelper.ADBHelper.Tap(deviceID, 70, 360);
                    Delay(1000);
                    if (isStop)
                        return;
                    //Click level up
                    KAutoHelper.ADBHelper.Tap(deviceID, 120, 1198);
                    Delay(1000);
                    if (isStop)
                        return;
                    //Click vào quả pháo
                    KAutoHelper.ADBHelper.Tap(deviceID, 68, 798);
                    Delay(1000);
                    if (isStop)
                        return;
                    //Click level up
                    KAutoHelper.ADBHelper.Tap(deviceID, 619, 584);
                    Delay(7000);
                    if (isStop)
                        return;
                    //Click ok
                    KAutoHelper.ADBHelper.Tap(deviceID, 366, 1213);
                    Delay(2000);
                    if (isStop)
                        return;
                    //nói chuyện
                    //Pyro said: Matthew, Matthew, are you there? ...
                    clickConversation(deviceID, delayLong);
                    //Matthew said: It's Matthew. What's the situation ...
                    clickConversation(deviceID, delayLong);
                    //Pyro said: We've gone through the whole...
                    clickConversation(deviceID, delayLong);
                    //Matthew said: That's some good news, at least.
                    clickConversation(deviceID, delayLong);
                    //Pyro said: Gotta remind you ...
                    clickConversation(deviceID, delayLong);
                    //Matthew said: Thanks for the reminder...
                    clickConversation(deviceID, 7000);
                    //Click bậc thang
                    KAutoHelper.ADBHelper.Tap(deviceID, 139, 258);
                    Delay(1000);
                    if (isStop)
                        return;
                    //Click upgrade
                    KAutoHelper.ADBHelper.Tap(deviceID, 297, 710);
                    Delay(1000);
                    if (isStop)
                        return;
                    //Click upgrade tiếp
                    KAutoHelper.ADBHelper.Tap(deviceID, 342, 928);
                    Delay(6000);
                    if (isStop)
                        return;

                    //Click map
                    KAutoHelper.ADBHelper.Tap(deviceID, 351, 1211);
                    Delay(1000);
                    if (isStop)
                        return;
                    //Click man 1
                    KAutoHelper.ADBHelper.Tap(deviceID, 416, 323);
                    Delay(1000);
                    if (isStop)
                        return;
                    //nói chuyện
                    //Ellen said: This place is a disaster...
                    clickConversation(deviceID, delayLong);
                    //Matthew said: Books. The accumulated ...
                    clickConversation(deviceID, delayLong);
                    //Matthew said: If we're going to rebuild ...
                    clickConversation(deviceID, delayLong);
                    //Matthew said: Let's secure this place and see ...
                    clickConversation(deviceID, 1000);
                    //Click claim
                    KAutoHelper.ADBHelper.Tap(deviceID, 357, 835);
                    Delay(1000);
                    if (isStop)
                        return;
                    //Click 20 serum
                    KAutoHelper.ADBHelper.Tap(deviceID, 312, 496);
                    Delay(1000);
                    if (isStop)
                        return;
                    //Click withdraw
                    KAutoHelper.ADBHelper.Tap(deviceID, 529, 466);
                    Delay(1000);
                    if (isStop)
                        return;
                    //Click total balance
                    KAutoHelper.ADBHelper.Tap(deviceID, 433, 285);
                    Delay(1000);
                    if (isStop)
                        return;
                    //Click learn to earn more
                    KAutoHelper.ADBHelper.Tap(deviceID, 520, 390);
                    Delay(1000);
                    if (isStop)
                        return;
                    //Click X đỏ
                    KAutoHelper.ADBHelper.Tap(deviceID, 607, 201);
                    Delay(1000);
                    if (isStop)
                        return;

                    //------------------END NEW BIE STAGE

                    //Click back
                    KAutoHelper.ADBHelper.Tap(deviceID, 58, 1174);
                    Delay(delayLong);
                    if (isStop)
                        return;
                    //Click shelter
                    KAutoHelper.ADBHelper.Tap(deviceID, 364, 1221);
                    Delay(2000);
                    if (isStop)
                        return;

                    //Click ok
                    KAutoHelper.ADBHelper.Tap(deviceID, 366, 1158);
                    Delay(1000);
                    if (isStop)
                        return;

                    //Click invites
                    KAutoHelper.ADBHelper.Tap(deviceID, 442, 138);
                    Delay(1000);
                    if (isStop)
                        return;
                    //Click invite paragraph
                    KAutoHelper.ADBHelper.Tap(deviceID, 344, 578);
                    Delay(2000);
                    if (isStop)
                        return;

                    //Click x đỏ
                    KAutoHelper.ADBHelper.Tap(deviceID, 678, 47);
                    Delay(1000);
                    if (isStop)
                        return;

                    //Click x đỏ wallet
                    KAutoHelper.ADBHelper.Tap(deviceID, 607, 199);
                    Delay(1000);
                    if (isStop)
                        return;


                    //swipe to make the swore in the right place
                    //first swipe
                    KAutoHelper.ADBHelper.Swipe(deviceID, 635, 781, 594, 666);
                    Delay(1000);
                    if (isStop)
                        return;
                    //second swipe
                    KAutoHelper.ADBHelper.Swipe(deviceID, 522, 586, 530, 561);
                    Delay(1000);
                    if (isStop)
                        return;

                    /*------------------START STAGE 2----------------*/

                    //building
                    //Click building on the right of yellow car
                    screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
                    var buildingRightYellowCar = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, BUILDING_RIGHT_YELLOW_CAR_BMP);
                    if (buildingRightYellowCar != null)
                    {
                        KAutoHelper.ADBHelper.Tap(deviceID, buildingRightYellowCar.Value.X, buildingRightYellowCar.Value.Y);
                        Delay(delayLong);
                        if (isStop)
                            return;
                        //Click farm
                        KAutoHelper.ADBHelper.Tap(deviceID, 173, 311);
                        Delay(delayLong);
                        if (isStop)
                            return;
                    }

                    //Click plus_collect_1
                    screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
                    var plusCollectPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, PLUS_COLLECT_BMP);
                    if (plusCollectPoint != null)
                    {
                        KAutoHelper.ADBHelper.Tap(deviceID, plusCollectPoint.Value.X, plusCollectPoint.Value.Y);
                        Delay(delayLong);
                        if (isStop)
                            return;
                        //Click +
                        KAutoHelper.ADBHelper.Tap(deviceID, 112, 560);
                        Delay(delayLong);
                        if (isStop)
                            return;
                        //Click first guy
                        KAutoHelper.ADBHelper.Tap(deviceID, 69, 786);
                        Delay(delayLong);
                        if (isStop)
                            return;
                        //Click ok
                        KAutoHelper.ADBHelper.Tap(deviceID, 364, 502);
                        Delay(delayLong);
                        if (isStop)
                            return;
                    }

                    //Click plus collect 2
                    screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
                    var plusCollect2Point = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, PLUS_COLLECT_2_BMP);
                    if (plusCollect2Point != null)
                    {
                        KAutoHelper.ADBHelper.Tap(deviceID, plusCollect2Point.Value.X, plusCollect2Point.Value.Y);
                        Delay(delayLong);
                        if (isStop)
                            return;
                        //Click +
                        KAutoHelper.ADBHelper.Tap(deviceID, 112, 560);
                        Delay(delayLong);
                        if (isStop)
                            return;
                        //Click first guy
                        KAutoHelper.ADBHelper.Tap(deviceID, 69, 786);
                        Delay(delayLong);
                        if (isStop)
                            return;
                        //Click ok
                        KAutoHelper.ADBHelper.Tap(deviceID, 364, 502);
                        Delay(delayLong);
                        if (isStop)
                            return;
                    }


                    //swipe to left
                    KAutoHelper.ADBHelper.Swipe(deviceID, 665, 686, 555, 671);
                    Delay(1000);
                    if (isStop)
                        return;

                    //Click build farm 1
                    screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
                    var buildFarm1Point = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, BUILD_FARM_1_BMP);
                    if (buildFarm1Point != null)
                    {
                        KAutoHelper.ADBHelper.Tap(deviceID, buildFarm1Point.Value.X, buildFarm1Point.Value.Y);
                        Delay(1000);
                        if (isStop)
                            return;
                        //Click farm
                        KAutoHelper.ADBHelper.Tap(deviceID, 195, 309);
                        Delay(6000);
                        if (isStop)
                            return;
                    }

                    //Click build farm 2  
                    KAutoHelper.ADBHelper.Tap(deviceID, 451, 398);
                    Delay(1000);
                    if (isStop)
                        return;
                    //Click food storage
                    KAutoHelper.ADBHelper.Tap(deviceID, 180, 311);
                    Delay(2000);
                    if (isStop)
                        return;


                    //Click plus collect 3
                    screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
                    var plusCollect3Point = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, PLUS_COLLECT_3_BMP);
                    if (plusCollect3Point != null)
                    {
                        KAutoHelper.ADBHelper.Tap(deviceID, plusCollect3Point.Value.X, plusCollect3Point.Value.Y);
                        Delay(1000);
                        if (isStop)
                            return;
                        //Click +
                        KAutoHelper.ADBHelper.Tap(deviceID, 112, 560);
                        Delay(1000);
                        if (isStop)
                            return;
                        //Click first guy
                        KAutoHelper.ADBHelper.Tap(deviceID, 69, 786);
                        Delay(1000);
                        if (isStop)
                            return;
                        //Click ok
                        KAutoHelper.ADBHelper.Tap(deviceID, 364, 502);
                        Delay(2000);
                        if (isStop)
                            return;
                    }

                    //Click build farm 3
                    KAutoHelper.ADBHelper.Tap(deviceID, 286, 1000);
                    Delay(1000);
                    if (isStop)
                        return;
                    //Click biolab
                    KAutoHelper.ADBHelper.Tap(deviceID, 173, 571);
                    Delay(2000);
                    if (isStop)
                        return;

                    //Click map
                    KAutoHelper.ADBHelper.Tap(deviceID, 355, 1210);
                    Delay(1000);
                    if (isStop)
                        return;

                    screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
                    var stage1Point = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, STAGE1_BMP);
                    if (stage1Point != null)
                    {

                        KAutoHelper.ADBHelper.Tap(deviceID, stage1Point.Value.X, stage1Point.Value.Y);
                        Delay(1000);
                        if (isStop)
                            return;
                        //Click màn 1.1
                        playNewBie(deviceID, 141, 565);
                        if (isStop)
                            return;
                        //Click màn 1.2
                        playNewBie(deviceID, 286, 496);
                        if (isStop)
                            return;
                        //Click màn 1.3
                        playNewBie(deviceID, 481, 506);
                        if (isStop)
                            return;
                        //Click back
                        KAutoHelper.ADBHelper.Tap(deviceID, 58, 1174);
                        Delay(delayLong);
                        if (isStop)
                            return;
                    }

                    //Click shelter
                    KAutoHelper.ADBHelper.Tap(deviceID, 364, 1221);
                    Delay(delayLong);
                    if (isStop)
                        return;

                    //swipe to right
                    KAutoHelper.ADBHelper.Swipe(deviceID, 535, 671, 665, 686);
                    Delay(1000);
                    if (isStop)
                        return;

                    //Click upgrade rock to level 2
                    screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
                    var upgradeRockPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, UPGRADE_ROCK_BMP);
                    if (upgradeRockPoint != null)
                    {
                        KAutoHelper.ADBHelper.Tap(deviceID, upgradeRockPoint.Value.X, upgradeRockPoint.Value.Y);
                        Delay(delayLong);
                        if (isStop)
                            return;
                        //Click upgrade
                        screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
                        var greenUpgradeIconPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, GREEN_UPGRADE_ICON_BMP);
                        if (greenUpgradeIconPoint != null)
                        {
                            KAutoHelper.ADBHelper.Tap(deviceID, greenUpgradeIconPoint.Value.X, greenUpgradeIconPoint.Value.Y);
                        }
                        Delay(1000);
                        if (isStop)
                            return;
                        //Click upgrade 900 tomatoes
                        KAutoHelper.ADBHelper.Tap(deviceID, 360, 924);
                        Delay(delayLong);
                        if (isStop)
                            return;
                    }


                    //Click map
                    KAutoHelper.ADBHelper.Tap(deviceID, 355, 1210);
                    Delay(delayLong);
                    if (isStop)
                        return;

                    //Click màn 1
                    screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
                    stage1Point = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, STAGE1_BMP);
                    if (stage1Point != null)
                    {

                        KAutoHelper.ADBHelper.Tap(deviceID, stage1Point.Value.X, stage1Point.Value.Y);
                        Delay(delayLong);
                        if (isStop)
                            return;
                        //Click màn 1.4
                        playNewBie(deviceID, 597, 627);
                        //Click back
                        KAutoHelper.ADBHelper.Tap(deviceID, 58, 1174);
                        Delay(delayLong);
                        if (isStop)
                            return;
                    }


                    //Click shelter
                    KAutoHelper.ADBHelper.Tap(deviceID, 364, 1221);
                    Delay(delayLong);
                    if (isStop)
                        return;

                    //swipe to top
                    KAutoHelper.ADBHelper.Swipe(deviceID, 396, 760, 368, 682);
                    Delay(1000);
                    if (isStop)
                        return;

                    //click build farm 4
                    screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
                    var buildFarm4Point = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, BUILD_FARM_4_BMP);
                    if (buildFarm4Point != null)
                    {
                        KAutoHelper.ADBHelper.Tap(deviceID, buildFarm4Point.Value.X, buildFarm4Point.Value.Y);
                        Delay(delayLong);
                        if (isStop)
                            return;
                        //Click farm
                        KAutoHelper.ADBHelper.Tap(deviceID, 182, 311);
                        Delay(7000);
                        if (isStop)
                            return;
                    }

                    //Click plus collect 4
                    screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
                    var plusCollect4Point = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, PLUS_COLLECT_4_BMP);
                    if (plusCollect4Point != null)
                    {
                        KAutoHelper.ADBHelper.Tap(deviceID, plusCollect4Point.Value.X, plusCollect4Point.Value.Y);
                        Delay(delayLong);
                        if (isStop)
                            return;
                        //Click +
                        KAutoHelper.ADBHelper.Tap(deviceID, 112, 560);
                        Delay(delayLong);
                        if (isStop)
                            return;
                        //Click first guy
                        KAutoHelper.ADBHelper.Tap(deviceID, 69, 786);
                        Delay(delayLong);
                        if (isStop)
                            return;
                        //Click ok
                        KAutoHelper.ADBHelper.Tap(deviceID, 364, 502);
                        Delay(delayLong);
                        if (isStop)
                            return;
                    }


                    //Click map
                    KAutoHelper.ADBHelper.Tap(deviceID, 355, 1210);
                    Delay(1000);
                    if (isStop)
                        return;

                    //Click màn 1
                    screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
                    stage1Point = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, STAGE1_BMP);
                    if (stage1Point != null)
                    {

                        KAutoHelper.ADBHelper.Tap(deviceID, stage1Point.Value.X, stage1Point.Value.Y);
                        Delay(delayLong);
                        if (isStop)
                            return;
                        //Click màn 1.5
                        playNewBie(deviceID, 563, 813);
                        //Click màn 1.6
                        playNewBie(deviceID, 420, 917);
                    }

                    //Click màn 1
                    screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
                    stage1Point = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, STAGE1_BMP);
                    if (stage1Point != null)
                    {

                        KAutoHelper.ADBHelper.Tap(deviceID, stage1Point.Value.X, stage1Point.Value.Y);
                        Delay(delayLong);
                        if (isStop)
                            return;
                        //Click gift
                        KAutoHelper.ADBHelper.Tap(deviceID, 416, 1031);
                        Delay(delayLong);
                        if (isStop)
                            return;

                        //Click claim
                        KAutoHelper.ADBHelper.Tap(deviceID, 364, 957);
                        Delay(1000);
                        if (isStop)
                            return;
                        //Click ok
                        KAutoHelper.ADBHelper.Tap(deviceID, 347, 766);
                        Delay(1000);
                        if (isStop)
                            return;
                        //Click back
                        KAutoHelper.ADBHelper.Tap(deviceID, 58, 1174);
                        Delay(delayLong);
                        if (isStop)
                            return;
                    }


                    //Click shelter
                    KAutoHelper.ADBHelper.Tap(deviceID, 364, 1221);
                    Delay(delayLong);
                    if (isStop)
                        return;

                    //Click tomato
                    screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
                    var tomatoPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, TOMATO_BMP);
                    if (tomatoPoint != null)
                    {
                        KAutoHelper.ADBHelper.Tap(deviceID, tomatoPoint.Value.X, tomatoPoint.Value.Y);
                        Delay(2000);
                        if (isStop)
                            return;
                    }

                    //Click map
                    KAutoHelper.ADBHelper.Tap(deviceID, 355, 1210);
                    Delay(delayLong);
                    if (isStop)
                        return;

                    //Click màn 2
                    screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
                    var stage2Point = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, STAGE2_BMP);
                    if (stage2Point != null)
                    {

                        KAutoHelper.ADBHelper.Tap(deviceID, stage2Point.Value.X, stage2Point.Value.Y);
                        Delay(delayLong);
                        if (isStop)
                            return;
                        //Click màn 2.1
                        playNewBie(deviceID, 526, 206);
                        //Click màn 2.2
                        playNewBie(deviceID, 437, 338);

                        //Click back
                        KAutoHelper.ADBHelper.Tap(deviceID, 58, 1174);
                        Delay(delayLong);
                        if (isStop)
                            return;
                    }

                    //Click shelter
                    KAutoHelper.ADBHelper.Tap(deviceID, 364, 1221);
                    Delay(1000);
                    if (isStop)
                        return;

                    //Click school
                    screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
                    Delay(1000);
                    var schoolPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, SCHOOL_BMP);
                    Delay(1000);
                    if (schoolPoint != null)
                    {
                        KAutoHelper.ADBHelper.Tap(deviceID, schoolPoint.Value.X, schoolPoint.Value.Y);
                        Delay(2000);
                        if (isStop)
                            return;
                        //Click upgrade
                        screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
                        var greenUpgradeIconPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, GREEN_UPGRADE_ICON_BMP);
                        if (greenUpgradeIconPoint != null)
                        {
                            KAutoHelper.ADBHelper.Tap(deviceID, greenUpgradeIconPoint.Value.X, greenUpgradeIconPoint.Value.Y);
                            Delay(1000);
                            if (isStop)
                                return;
                        }
                        //Click upgrade 12k rocks
                        KAutoHelper.ADBHelper.Tap(deviceID, 342, 926);
                        Delay(1000);
                        if (isStop)
                            return;
                    }

                    //Click map
                    KAutoHelper.ADBHelper.Tap(deviceID, 355, 1210);
                    Delay(delayLong);
                    if (isStop)
                        return;

                    //Click màn 2
                    screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
                    stage2Point = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, STAGE2_BMP);
                    if (stage2Point != null)
                    {

                        KAutoHelper.ADBHelper.Tap(deviceID, stage2Point.Value.X, stage2Point.Value.Y);
                        Delay(delayLong);
                        if (isStop)
                            return;
                        //Click màn 2.3
                        playNewBie(deviceID, 351, 457);
                    }





                    /*------------------END STAGE 2----------------*/









                    ////Nếu có lệnh stop thì dừng toàn bộ
                    //if (isStop)
                    //    return;





                });
                t.Start();
            }
        }


        void Delay(int delay)
        {
            while (delay > 0)
            {
                Thread.Sleep(TimeSpan.FromMilliseconds(1));
                delay--;
                if (isStop)
                    break;
            }
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            isStop = true;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //Lấy ra danh sách devices để dùng
            List<string> devices = new List<string>();
            devices = KAutoHelper.ADBHelper.GetDevices();

            //Chạy từng device
            foreach (var deviceID in devices)
            {
                //Tạo ra 1 luồng xử lí riêng biệt
                Task t1 = new Task(() =>
                {
                    /*------------------START STAGE 2----------------*/

                    //building
                    //Click building on the right of yellow car
                    while (true)
                    {
                        playSwap(deviceID);
                    }

                    /*------------------END STAGE 2----------------*/
                });
                t1.Start();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/C memuc listvms -r";
            //p.StartInfo.Arguments = "/C adb connect localhost:21523";
            p.Start();

            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            System.Diagnostics.Debug.WriteLine($"Current devices: {output}");
            string[] arrListStr = output.Split('\n');

            //Đoạn này để cmd ko bị treo
            p.StartInfo.Arguments = $"/C adb devices";
            p.Start();
            p.WaitForExit();
            for (int i = 0; i < arrListStr.Length; i++)
            {
                if (arrListStr[i].Length > 0)
                {
                    char currentDevice = arrListStr[i][0];
                    if (currentDevice - '0' >= 0)
                    {
                        p.StartInfo.Arguments = $"/C adb connect 127.0.0.1:215{currentDevice}3";
                        p.Start();
                        output = p.StandardOutput.ReadToEnd();
                        p.WaitForExit();
                        System.Diagnostics.Debug.WriteLine(output);
                        MessageBox.Show(output, "Connect devices");
                    }

                }
            }

        }
    }
}
