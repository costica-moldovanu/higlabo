﻿using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HigLabo.Web.RazorComponent.Input
{
    public partial class InputFieldPanel_RecordList
    {
        [Parameter]
        public InputFieldPanelLayout Layout { get; set; } = InputFieldPanelLayout.Default;
        [Parameter]
        public string Name { get; set; } = "";
        [Parameter]
        public string Text { get; set; } = "";
        [Parameter]
        public bool FieldNameVisible { get; set; } = true;
        [Parameter]
        public AddRecordMode AddRecordMode { get; set; } = AddRecordMode.Add;
        [Parameter]
        public bool MultipleSelectRecord { get; set; } = true;

        [Parameter]
        public RenderFragment? ChildContent { get; set; }
        [Parameter]
        public InputValidateResult ValidateResult { get; set; } = new InputValidateResult(true);

        [Parameter]
        public bool SelectRecordPanelVisible { get; set; } = false;
        [Parameter]
        public bool SearchContainerPanelVisible { get; set; } = true;

        [Parameter]
        public EventCallback<RecordListLoadingContext> OnRecordListLoading { get; set; }
        [Parameter]
        public EventCallback OnRecordAdded { get; set; }
        [Parameter]
        public EventCallback<InputFieldPanelRecord> OnRecordSelected { get; set; }
        [Parameter]
        public EventCallback OnRecordDropped { get; set; }

        private async ValueTask OnAddIconClicked()
        {
            switch (this.AddRecordMode)
            {
                case AddRecordMode.Add:
                    await this.OnRecordAdded.InvokeAsync();
                    break;
                case AddRecordMode.Select:
                    this.SelectRecordPanelVisible = !this.SelectRecordPanelVisible;
                    break;
                default:throw SwitchStatementNotImplementException.Create(this.AddRecordMode);
            }
        }
        private async ValueTask Record_Selected(InputFieldPanelRecord record)
        {
            if (this.MultipleSelectRecord == false)
            {
                this.SelectRecordPanelVisible = false;
            }
            await this.OnRecordSelected.InvokeAsync(record);
        }
    }
}
