﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamTabbed
{
	public partial class UpcomingAppointmentsPage : ContentPage
	{
		public UpcomingAppointmentsPage()
		{
			InitializeComponent();
		}

		async void OnBackButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PopAsync();
		}
	}
}
