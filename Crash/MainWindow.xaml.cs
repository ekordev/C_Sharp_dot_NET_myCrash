using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Crash
{
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window
   {
      public MainWindow()
      {
         InitializeComponent();
      }

      // Instantiate new Crash object
      theCrash crash = new theCrash();

      // Local window input variables
      double friction;
      double distance;
      double velocity;
      double time;
      double radius;
      double speed;
      double chord;
      double middleOrdinate;

      private void Window_Loaded(object sender, RoutedEventArgs e)
      {

      }

      // Calculate Speed1 ---------------------------------------------------
      private void button_GetSpeed_Click(object sender, RoutedEventArgs e)
      {
         // Get Inputs
         try
         {
            friction = double.Parse(textBox_Friction.Text);
            distance = double.Parse(textBox_Dist.Text);
         }
         catch (Exception ex)
         {
            MessageBox.Show("Next time try not to mess up!\n\n" + ex.Message);
         }

         // Calculate result
         try
         {
            double localSpeed = crash.calcSpeed1(distance, friction);
            textBox_Speed.Text = localSpeed.ToString("0.00");
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }//end speed1 

      // Calculate Speed2 ---------------------------------------------------
      private void button_GetSpeed2_Click(object sender, RoutedEventArgs e)
      {
         // Get Inputs
         try
         {
            friction = double.Parse(textBox_FrictionSpeed2.Text);
            radius = double.Parse(textBox_RadiusSpeed2.Text);
         }
         catch (Exception ex)
         {
            MessageBox.Show("Seriously?\n\n" + ex.Message);
         }

         // Calculate result
         try
         {
            double localSpeed = crash.calcCriticalSpeed(radius, friction);
            textBox_Speed2.Text = localSpeed.ToString("0.00");
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }//end speed2

      // Calculate Distance 1  ---------------------------------------------------
      private void button_GetDist1_Click(object sender, RoutedEventArgs e)
      {
         // Get Inputs
         try
         {
            speed = double.Parse(textBox_SpeedDist1.Text);
            friction = double.Parse(textBox_FrictionDist1.Text);
         }
         catch (Exception ex)
         {
            MessageBox.Show("Were you dropped on your head as a baby?\n\n" + ex.Message);
         }

         // Calculate result
         try
         {
            double localDist1 = crash.calcDistance1(speed, friction);
            textBox_Dist1.Text = localDist1.ToString("0.00");
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }//end distance 1

      // Calculate Distance 2  ---------------------------------------------------
      private void button_GetDist2_Click(object sender, RoutedEventArgs e)
      {
         // Get Inputs
         try
         {
            time = double.Parse(textBox_TimeDist2.Text);
            friction = double.Parse(textBox_FrictionDist2.Text);
         }
         catch (Exception ex)
         {
            MessageBox.Show("Nobody said you were the smart one. \n\n" + ex.Message);
         }

         // Calculate result
         try
         {
            double localDist2 = crash.calcDistance2(time, friction);
            textBox_Dist2.Text = localDist2.ToString("0.00");
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }//end distance 2  

      // Calculate Time --------------------------------------------------------
      private void button_GetTime_Click(object sender, RoutedEventArgs e)
      {

         // Get Inputs
         try
         {
            distance = double.Parse(textBox_Distance2.Text);
            velocity = double.Parse(textBox_Velocity2.Text);
         }
         catch (Exception ex)
         {
            MessageBox.Show("Maybe you should consider retirement. \n\n" + ex.Message);
         }

         // Calculate result
         try
         {
            double localTime = crash.calcTime(distance, velocity);
            textBox_Time2.Text = localTime.ToString("0.00");
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }//end Time

      // Calculate Radius --------------------------------------------------------
      private void button_GetRadius_Click(object sender, RoutedEventArgs e)
      {
         // Get Inputs
         try
         {
            chord = double.Parse(textBox_Chord.Text);
            middleOrdinate = double.Parse(textBox_MiddleOrd.Text);
         }
         catch (Exception ex)
         {
            MessageBox.Show("Maybe it's time for you to take a break. \n\n" + ex.Message);
         }

         // Calculate result
         try
         {
            double localRadius = crash.calcRadius(chord, middleOrdinate);
            textBox_Radius.Text = localRadius.ToString("0.00");
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void button_GetVelocity_Click(object sender, RoutedEventArgs e)
      {
         // Get Inputs
         try
         {
            speed = double.Parse(textBox_SpeedinVelocity.Text);
         }
         catch (Exception ex)
         {
            MessageBox.Show("Try harder! \n\n" + ex.Message);
         }

         // Calculate result
         try
         {
            double localVelocity = crash.calcVelocity(speed);
            textBox_Velocity.Text = localVelocity.ToString("0.00");
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }//end Velocity
   }//end class
}//end namespace


