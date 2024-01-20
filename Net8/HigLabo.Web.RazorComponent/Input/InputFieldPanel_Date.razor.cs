﻿using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HigLabo.Web.RazorComponent.Input
{
    public partial class InputFieldPanel_Date 
    {
        private string _ValueInputing = "";

        [Parameter]
        public InputFieldPanelLayout Layout { get; set; } = InputFieldPanelLayout.Default;
        [Parameter]
        public string Name { get; set; } = "";
        [Parameter]
        public string Text { get; set; } = "";
        [Parameter]
        public string Value { get; set; } = "";
        [Parameter]
        public InputValidateResult ValidateResult { get; set; } = new InputValidateResult(true);
        [Parameter]
        public DateDirection DateDirection { get; set; } = DateDirection.Future;
        [Parameter]
        public string DateTimeFormat { get; set; } = "yyyy/MM/dd";
        [Parameter]
        public TimeOnly TimeZone { get; set; } = new TimeOnly(0, 0);
        [Parameter]
        public bool SelectDateCalendarPanelVisible { get; set; } = false;
        [Parameter]
        public EventCallback<FocusEventArgs> OnTextboxBlur { get; set; }

        private void InputText_Input(ChangeEventArgs e)
        {
            if (e.Value == null)
            {
                _ValueInputing = "";
                return;
            }
            var v = e.Value.ToString();
            if (v == null)
            {
                _ValueInputing = "";
                return;
            }

            var pr = new NumberToDateTimeProcessor(this.TimeZone, this.DateDirection);
            pr.Converters.Clear();
            pr.Converters.Add(new NumberToDateTimeConverter_Mdd());
            pr.Converters.Add(new NumberToDateTimeConverter_MMdd());
            pr.Converters.Add(new NumberToDateTimeConverter_yyyyMMdd());

            var date = pr.Convert(v);
            if (date.HasValue)
            {
                this._ValueInputing = date.Value.ToString(this.DateTimeFormat);
                Debug.WriteLine($"{v} --> {_ValueInputing}");
            }
            else
            {
                _ValueInputing = "";
            }
        }
        private async ValueTask Textbox_Blur(FocusEventArgs e)
        {
            if (_ValueInputing.IsNullOrEmpty() == false)
            {
                this.Value = this._ValueInputing;
            }
            await this.OnTextboxBlur.InvokeAsync(e);
        }

        private void DateSelected_Callback(DateOnly? date)
        {
            this.SelectDateCalendarPanelVisible = false;
            if (date.HasValue)
            {
                this.Value = date.Value.ToString(this.DateTimeFormat);
            }
        }
    }
}
