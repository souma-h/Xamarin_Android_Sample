using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;


namespace App1
{
    [Activity(Label = "App1", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        string sdisply = "";

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button0 = FindViewById<Button>(Resource.Id.Button0);
            Button button1 = FindViewById<Button>(Resource.Id.Button1);
            Button button2 = FindViewById<Button>(Resource.Id.Button2);
            Button button3 = FindViewById<Button>(Resource.Id.Button3);
            Button button4 = FindViewById<Button>(Resource.Id.Button4);
            Button button5 = FindViewById<Button>(Resource.Id.Button5);
            Button button6 = FindViewById<Button>(Resource.Id.Button6);
            Button button7 = FindViewById<Button>(Resource.Id.Button7);
            Button button8 = FindViewById<Button>(Resource.Id.Button8);
            Button button9 = FindViewById<Button>(Resource.Id.Button9);
            Button buttontasu = FindViewById<Button>(Resource.Id.Buttontasu);
            Button buttonhiku = FindViewById<Button>(Resource.Id.Buttonhiku);
            Button buttonkake = FindViewById<Button>(Resource.Id.Buttonkake);
            Button buttonwaru = FindViewById<Button>(Resource.Id.Buttonwaru);
            Button buttonten = FindViewById<Button>(Resource.Id.Buttonten);
            Button buttonkesu = FindViewById<Button>(Resource.Id.Buttonkesu);

            Button buttonwa = FindViewById<Button>(Resource.Id.Buttonwa);


            //button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
            button0.Click += button_Click;
            button1.Click += button_Click;
            button2.Click += button_Click;
            button3.Click += button_Click;
            button4.Click += button_Click;
            button5.Click += button_Click;
            button6.Click += button_Click;
            button7.Click += button_Click;
            button8.Click += button_Click;
            button9.Click += button_Click;
            buttontasu.Click += button_Click;
            buttonhiku.Click += button_Click;
            buttonkake.Click += button_Click;
            buttonwaru.Click += button_Click;
            buttonten.Click += button_Click;

            buttonkesu.Click += buttonkesu_Click;

            buttonwa.Click += buttonwa_Click;

        }

        private void button_Click(object sender, EventArgs e)
        {
            TextView textview1 = FindViewById<TextView>(Resource.Id.textView1);

            sdisply = sdisply + ((Button)sender).Text;

            textview1.Text = sdisply;

        }

        private void buttonwa_Click(object sender, EventArgs e)
        {
            TextView textview1 = FindViewById<TextView>(Resource.Id.textView1);
            System.Data.DataTable dt = new System.Data.DataTable();
            double result = double.Parse(dt.Compute(textview1.Text, "").ToString());
            textview1.Text = result.ToString();
            sdisply = result.ToString();

        }

        private void buttonkesu_Click(object sender, EventArgs e)
        {
            TextView textview1 = FindViewById<TextView>(Resource.Id.textView1);

            sdisply = "";

            textview1.Text = sdisply;

        }


    }
}

