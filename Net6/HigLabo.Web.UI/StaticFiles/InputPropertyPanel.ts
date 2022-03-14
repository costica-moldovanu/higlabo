﻿import { DateOnly, DateTime } from "./DateTime.js";
import { $ } from "./HtmlElementQuery.js";
import { HigLaboVue } from "./HigLaboVue.js";
import { HttpClient, HttpResponse } from "./HttpClient.js";
import { CKEditorTextBox } from "./CKEditorTextBox.js";
import SelectTimePopupPanel from "./SelectTimePopupPanel.js";
import { TinyMceTextBox } from "./TinyMceTextBox.js";

export class InputPropertyPanel {
    private _eventHandlerList = new Array<RecordAddedEventHandler>();
    public selectTimePopupPanel = new SelectTimePopupPanel();

    public initialize() {
        this.selectTimePopupPanel.initialize();

        $("body").find("input").forEach((element, index) => {
            $(element).setAttribute("previous-value", $(element).getValue());
        });
        $("body").on("change", "input", this.input_Change.bind(this));

        $("body").on("focusin", "input[date-picker],input[time-picker]", this.dateTimeTextBox_Focusin.bind(this));
        $("body").on("keydown", "input[date-picker]", this.dateTextBox_Keydown.bind(this));
        $("body").on("keydown", "input[time-picker]", this.timeTextBox_Keydown.bind(this));

        $("body").on("keydown", "[input-property-panel][element-type='Color'] input[type=text]", this.colorTextBox_Keydown.bind(this));
        $("body").on("keyup", "[input-property-panel][element-type='Color'] input[type=text]", this.colorTextBox_Keyup.bind(this));
        $("body").on("click", "[input-property-panel][element-type='Color'] [color-panel]", this.colorPanel_Click.bind(this));
        $("body").on("click", "[input-property-panel][element-type='Color'] td[color]", this.colorCell_Click.bind(this));
        $("body").on("keydown", "[input-property-panel][element-type='Color'] td[color]", this.colorCell_Keydown.bind(this));

        $("body").on("change", "[input-property-panel] [set-by-end-time]", this.dateTimeDurationList_Change.bind(this));
        $("body").on("change", "[input-property-panel][element-type='DateDropDownList'] [year]", this.dateDrowDownList_Change.bind(this));
        $("body").on("change", "[input-property-panel][element-type='DateDropDownList'] [month]", this.dateDrowDownList_Change.bind(this));
        $("body").on("keydown", "[input-property-panel][element-type='DateDropDownList'] select", this.dateDrowDownList_Keydown.bind(this));

        $("body").on("click", "[input-property-panel]  [radio-button-label]", this.radioButtonLabel_Click.bind(this));
        $("body").on("click", "[input-property-panel]  [checkbox-label]", this.checkBoxLabel_Click.bind(this));
        $("body").on("input", "[input-property-panel] [filter-textbox]", this.filterTextBox_Keydown.bind(this));

        $("body").on("keydown", "[input-property-panel] [delete-link]", this.deleteLink_Keydown.bind(this));
        $("body").on("click", "[input-property-panel] [delete-link]", this.deleteLink_Click.bind(this));
        $("body").on("click", "[input-property-panel] [add-record-button]", this.addRecordButton_Click.bind(this));
        $("body").on("click", "[input-property-panel] [select-record-panel]", this.selectRecordPanel_Click.bind(this));
        $("body").on("keydown", "[input-property-panel] [select-record-panel]", this.selectRecordPanel_Keydown.bind(this));
        $("body").on("click", "[input-property-panel] [search-button]", this.searchButton_Click.bind(this));
        $("body").on("keydown", "[input-property-panel] [search-textbox]", this.searchTextBox_Keydown.bind(this));
        $("body").on("click", "[input-property-panel] [record-list-panel] [h-record]", this.record_Click.bind(this));
        $("body").on("click", "[input-property-panel] [sort-button]", this.sortButton_Click.bind(this));
        $("body").on("click", "[input-property-panel] [select-record-list-panel] [sort-record]", this.sortRecord_Click.bind(this));
        $("body").on("click", "[input-property-panel] [close-button]", this.closeButton_Click.bind(this));

        $("body").on("keyup", "[input-property-panel] [select-record-list-panel] [header-text-binding-panel] input[type=text]", this.editRecordPanelTextBox_Keyup.bind(this));
        $("body").on("keydown", "[input-property-panel] [select-record-list-panel] [toggle-content-panel]", this.toggleContentPanel_Keydown.bind(this));
        $("body").on("click", "[input-property-panel] [select-record-list-panel] [toggle-content-panel]", this.toggleContentPanel_Click.bind(this));
        $("body").on("keydown", "[input-property-panel] [select-record-list-panel] [header-text]", this.headerText_Keydown.bind(this));
        $("body").on("click", "[input-property-panel] [select-record-list-panel] [delete-candidate-link]", this.deleteCandidateLink_Click.bind(this));

        this.initializeSetByEndTimeProperty();
    }
    public registerEventHandler(hander: RecordAddedEventHandler) {
        this._eventHandlerList.push(hander);
    }

    private initializeSetByEndTimeProperty() {
        var ipl = this;
        $("[input-property-panel] [set-by-end-time]").forEach((element, index) => {
            ipl.toggleDateTimeDurationList(element);
        });
    }

    private input_Change(target: Element, e: Event) {
        $(target).setAttribute("previous-value", $(target).getValue());
    }
    private dateTimeTextBox_Focusin(target: Element, e: Event) {
        $(target).select();
    }
    private dateTextBox_Keydown(target: Element, e: KeyboardEvent) {
        const ftx = target as any;
        if (ftx._flatpickr != null) {
            if (e.keyCode == 40) {
                ftx._flatpickr.open();
            }
            else {
                ftx._flatpickr.close();
            }
        }

        if (e.keyCode != 9) { return; }

        var tx = $(target);
        var text = tx.getValue();
        var value = parseInt(text);

        if (isNaN(value) == true) { return; }

        var today = DateTime.getToday();
        var date = new DateOnly();

        if (text.length <= 2) {
            date.Year = today.year;
            date.Month = today.month;
            date.Day = value;
        }
        else if (text.length == 3) {
            date.Year = today.year;
            date.Month = parseInt(text.substr(0, 1));
            date.Day = parseInt(text.substr(1, 2));
        }
        else if (text.length == 4) {
            date.Year = today.year;
            date.Month = parseInt(text.substr(0, 2));
            date.Day = parseInt(text.substr(2, 2));
        }
        else if (text.length == 5) {
            date.Year = parseInt("20" + text.substr(0, 2));
            date.Month = parseInt(text.substr(2, 1));
            date.Day = parseInt(text.substr(3, 2));
        }
        else if (text.length == 6) {
            date.Year = parseInt("20" + text.substr(0, 2));
            date.Month = parseInt(text.substr(2, 2));
            date.Day = parseInt(text.substr(4, 2));
        }
        else if (text.length == 8) {
            date.Year = parseInt(text.substr(0, 4));
            date.Month = parseInt(text.substr(4, 2));
            date.Day = parseInt(text.substr(6, 2));
        }
        else {
            return;
        }

        let dateTime = new DateTime(date);
        if (text.length == 1 || text.length == 2) {
            if (dateTime.value < today.value) {
                dateTime = today.addMonth(1);
            }
        }
        tx.setValue(dateTime.toString("yyyy/MM/dd"));
    }
    private timeTextBox_Keydown(target: Element, e: KeyboardEvent) {
        if (e.keyCode == 40) {
            this.selectTimePopupPanel.show(target);
        }
        else {
            this.selectTimePopupPanel.hide();
        }

        if (e.keyCode != 9) { return; }

        var tx = $(target);
        var text: string = tx.getValue();

        if (text.length == 1) {
            var hour = parseInt(text);
            var minute = 0;
        }
        if (text.length == 2) {
            var hour = parseInt(text);
            var minute = 0;
        }
        if (text.length == 3) {
            var hour = parseInt("0" + text.substr(0, 1));
            var minute = parseInt(text.substr(1, 2));
        }
        if (text.length == 4) {
            var hour = parseInt(text.substr(0, 2));
            var minute = parseInt(text.substr(2, 2));
        }
        if (text.length == 5) {
            var hour = parseInt(text.substr(0, 2));
            var minute = parseInt(text.substr(3, 2));
        }
        if (minute == NaN) {
            minute = 0;
        }
        if (0 <= hour && hour < 30 &&
            0 <= minute && minute < 60) {
            if (hour < 10) {
                if (minute < 10) {
                    tx.setValue("0" + hour + ":0" + minute);
                }
                else {
                    tx.setValue("0" + hour + ":" + minute);
                }
            }
            else {
                if (minute < 10) {
                    tx.setValue(hour + ":0" + minute);
                }
                else {
                    tx.setValue(hour + ":" + minute);
                }
            }
        }
        else {
            tx.setValue("");
        }
    }

    private colorTextBox_Keydown(target: Element, e: KeyboardEvent) {
        if (e.keyCode == 13) {
            this.showColorTable(target);
        }
    }
    private colorTextBox_Keyup(target: Element, e: Event) {
        $(target).getNearest("[color-panel]").setStyle("background-color", $(target).getValue());
    }
    private colorPanel_Click(target: Element, e: Event) {
        this.showColorTable(target);
    }
    private showColorTable(target: Element) {
        $(target).getNearest("[color-table-panel]").setStyle("display", "block");
        $(target).getNearest("[color-table-panel]").find("td").setFocus();
    }
    private colorCell_Click(target: Element, e: Event) {
        var color = $(target).getAttribute("color");
        this.setColor(target, color);
    }
    private colorCell_Keydown(target: Element, e: KeyboardEvent) {
        const tr = target.parentElement;

        if (e.keyCode == 13) {
            var color = $(target).getAttribute("color");
            this.setColor(target, color);
        }
        else if (e.keyCode == 37) {
            if (target.previousElementSibling == null) {
                const td = $(target).getParent("tr").find("td").getLastElement();
                $(td).setFocus();
            }
            else {
                $(target.previousElementSibling).setFocus();
            }
            e.preventDefault();
        }
        else if (e.keyCode == 38) {
            const index = $(target).getIndex();
            $(tr.previousElementSibling.children[index]).setFocus();
            e.preventDefault();
        }
        else if (e.keyCode == 39) {
            if (target.nextElementSibling == null) {
                const td = $(target).getParent("tr").find("td").getFirstElement();
                $(td).setFocus();
            }
            else {
                $(target.nextElementSibling).setFocus();
            }
            e.preventDefault();
        }
        else if (e.keyCode == 40) {
            const index = $(target).getIndex();
            $(tr.nextElementSibling.children[index]).setFocus();
            e.preventDefault();
        }
    }
    private setColor(target: Element, color: string) {
        $(target).getNearest("[color-panel]").setStyle("background-color", color);
        $(target).getNearest("[color-table-panel]").hide();
        $(target).getNearest("input[type='text']").setValue(color).setFocus().select();
    }

    private dateTimeDurationList_Change(target: Element, e: Event) {
        this.toggleDateTimeDurationList(target);
    }
    public toggleDateTimeDurationList(target: Element) {
        const durationListPanel = $(target).getNearestElement("[duration-list-panel]");
        const durationEndPanel = $(target).getNearestElement("[duration-end-panel]");
        if ($(target).isChecked()) {
            $(durationListPanel).setStyle("display", "none");
            $(durationEndPanel).setStyle("display", "inline");
        }
        else {
            $(durationListPanel).setStyle("display", "inline");
            $(durationEndPanel).setStyle("display", "none");
        }
    }
    private dateDrowDownList_Change(target: Element, e: Event) {
        const ipl = $(target).getFirstParent("[input-property-panel]").getFirstElement();
        const year = $(ipl).find("[year]").getSelectedValue();
        const month = $(ipl).find("[month]").getSelectedValue();
        const date = new DateTime(year + "/" + month + "/01");
        const nextMonth = date.addMonth(1);
        const lastDayOfMonth = nextMonth.addDay(-1);
        const day = lastDayOfMonth.day;

        const dl = $(ipl).find("[day]").getFirstElement();
        $(dl).setInnerHtml("");
        for (var i = 1; i <= day; i++) {
            let option = document.createElement("option");
            $(option).setAttribute("value", i.toString());
            let day = i.toString();
            if (day.length == 1) {
                day = "0" + day;
            }
            $(option).setInnerText(day);
            dl.appendChild(option);
        }
        $(dl).setSelectedValue("1");
    }
    private dateDrowDownList_Keydown(target: Element, e: KeyboardEvent) {
        if (e.shiftKey == true || e.ctrlKey == true || e.altKey == true) { return; }

        let x = -1;
        if (e.keyCode >= 48 && e.keyCode < 58) {
            x = e.keyCode - 48;
        }
        if (e.keyCode >= 96 && e.keyCode < 106) {
            x = e.keyCode - 96;
        }
        if (x > -1) {
            let v = $(target).getAttribute("key-input-value") + x.toString();
            if ($(target).getAttribute("year") == "true") {
                if (v.length > 4) {
                    v = v.substr(v.length - 4, 4);
                }
            }
            else if ($(target).getAttribute("month") == "true") {
                v = v.substr(v.length - 2, 2);
                if (v.substr(0, 1) == "0") {
                    v = v.substr(1, 1);
                }
                if (parseInt(v) > 12) {
                    v = v.substr(1, 1);
                }
            }
            else if ($(target).getAttribute("day") == "true") {
                v = v.substr(v.length - 2, 2);
                if (v.substr(0, 1) == "0") {
                    v = v.substr(1, 1);
                }
                if (parseInt(v) > 31) {
                    v = v.substr(1, 1);
                }
            }
            $(target).setSelectedValue(v);
            $(target).setAttribute("key-input-value", v);
            e.preventDefault();
        }
    }

    private radioButtonLabel_Click(target: Element, e: Event) {
        $(target).getNearest("input[type='radio']").setChecked(true).triggerEvent("change");
    }
    private checkBoxLabel_Click(target: Element, e: Event) {
        $(target).getNearest("input[type='checkbox']").toggleChecked().triggerEvent("change");
    }
    private filterTextBox_Keydown(target: Element, e: KeyboardEvent) {
        const ipl = $(target).getFirstParent("[input-property-panel]").getFirstElement();
        const text = $(target).getValue();
        if (text == "") {
            $(ipl).find("[filter-text]").removeClass("display-none");
        }
        else {
            $(ipl).find("[filter-text]").addClass("display-none");
            $(ipl).find("[filter-text*='" + text + "']").removeClass("display-none");
        }
    }

    private selectRecordPanel_Click(target: Element, e: Event) {
        this.showSearchRecordListPanel(target);
    }
    private selectRecordPanel_Keydown(target: Element, e: KeyboardEvent) {
        if (e.keyCode == 13) {
            this.showSearchRecordListPanel(target);
        }
    }

    private deleteLink_Click(target: Element, e: Event) {
        this.deleteRecord(target);
        e.preventDefault();
    }
    private deleteLink_Keydown(target: Element, e: KeyboardEvent) {
        if (e.keyCode == 13) {
            const pl = $(target).getParent("[h-record]").getFirstElement();
            let focusElement = pl.nextElementSibling;
            if (focusElement == null) {
                focusElement = pl.previousElementSibling;
            }
            if (focusElement != null) {
                $(focusElement).find("[delete-link]").setFocus();
            }
            this.deleteRecord(target);
        }
    }
    private deleteRecord(target: Element) {
        const pl = $(target).getParent("[h-record]").getFirstElement();

        const elementType = $(target).getParentAttribute("element-type");
        if (elementType == "Record") {
            const rpl = $(target).getNearestElement("[select-record-panel]");

            $(rpl).setInnerHtml("");
            const span = document.createElement("span");
            $(span).setInnerText(rpl.getAttribute("default-text"));
            rpl.appendChild(span);

            $(rpl).setFocus();
        }
        pl.remove();
    }

    private addRecordButton_Click(target: Element, e: Event) {
        const ipl = $(target).getParent("[input-property-panel]");
        const mode = ipl.getAttribute("add-record-mode");

        switch (mode) {
            case "None":
                this.setDefaultRecord(ipl.getFirstElement(), {});
                break;
            case "Search":
                $(target).getParent("[button-list-panel]").hide();
                this.showSearchRecordListPanel(target);
                break;
            case "Api":
                const apiPath = ipl.getAttribute("api-path-default-get");

                HttpClient.postJson(apiPath, {}, this.getDefaultRecordCallback.bind(this), null
                    , ipl.getFirstElement());
                break;
            default:
        }
    }
    private setDefaultRecord(inputPropertyPanel: Element, record) {
        const r = record;

        const ipl = inputPropertyPanel;
        const templateID = ipl.getAttribute("template-id");
        const rpl = $(ipl).find("[select-record-list-panel]").getFirstElement();
        const element = HigLaboVue.append(rpl, templateID, r)[0];
        if ($(element).getAttribute("header-mode") == "Label") {
            $(element).setAttribute("toggle-state", "Expand");
        }
        var key = $(element).getAttribute("h-key");
        InputPropertyPanel.setElementProperty(element, r, key);
        $(element).find("input[type='text']").setFocus();
        this.recordAdded(ipl);
    }
    private getDefaultRecordCallback(response: HttpResponse, inputPropertyPanel: Element) {
        const r = response.jsonParse();
        this.setDefaultRecord(inputPropertyPanel, r);
    }
    private recordAdded(inputPropertyPanel: Element) {
        const e = new RecordAddedEvent(inputPropertyPanel);
        for (var i = 0; i < this._eventHandlerList.length; i++) {
            try {
                var f = this._eventHandlerList[i];
                f(this, e);
            }
            catch {

            }
        }
    }
    private showSearchRecordListPanel(target: Element) {
        const pl = $(target).getNearestElement("[search-record-list-panel]");
        $(pl).addClass("slide-down");
        $(target).getNearest("[search-textbox]").setFocus();
        this.search(target);
    }

    private searchButton_Click(target: Element, e: Event) {
        this.search(target);
    }
    private searchTextBox_Keydown(target: Element, e: KeyboardEvent) {
        const pl = $(target).getNearest("[search-record-list-panel]");
        const currentElement = pl.find("[current]").getFirstElement();
        let targetElement = null;

        if (e.keyCode == 13) {
            if (currentElement == null) {
                this.search(target);
                return;
            }
            else {
                targetElement = currentElement.nextElementSibling;
                if (targetElement == null) {
                    targetElement = currentElement.previousElementSibling;
                }
                const selected = this.selectRecord(currentElement);
                if (selected == false) {
                    return;
                }
            }
        }

        const elementList = pl.find("[h-record]").getElementList();
        if (elementList.length == 0) { return; }

        if (e.keyCode == 8) {
            targetElement = null;
        }
        else if (e.keyCode == 38) {
            if (currentElement == null) {
                targetElement = elementList[elementList.length - 1];
            }
            else {
                currentElement.removeAttribute("current");
                targetElement = currentElement.previousSibling;
            }
        }
        else if (e.keyCode == 40) {
            const currentElement = pl.find("[current]").getFirstElement();
            if (currentElement == null) {
                targetElement = elementList[0];
            }
            else {
                currentElement.removeAttribute("current");
                targetElement = currentElement.nextElementSibling;
            }
        }
        if (targetElement == null) {
            pl.find("[current]").removeAttribute("current");
        }
        else {
            const rpl = pl.find("[record-list-panel]");
            const parentOffset = rpl.getOffset();
            const scrollTop = rpl.getScrollTop();
            const offset = $(targetElement).getOffset();
            rpl.setScrollTop((offset.top) - (parentOffset.top - scrollTop) - (rpl.getOuterHeight() / 2) + 40);
        }
        $(targetElement).setAttribute("current", "true");
    }
    private search(target: Element) {
        const pl = $(target).getParent("[api-path-search]");
        const url = $(pl).getAttribute("api-path-search");
        let p = null;
        try {
            p = JSON.parse($(pl).getAttribute("api-parameter"));
        }
        catch { }
        if (p == null) { p = {}; }
        p.SearchText = $(pl).find("[search-textbox]").getValue();
        HttpClient.postJson(url, p, this.search_Callback.bind(this), null, pl);
    }
    private search_Callback(response: HttpResponse, context: any) {
        const data = response.jsonParse();
        const pl = context;
        const recordListPanel = $(pl).find("[record-list-panel]").getFirstElement();
        const templateID = $(pl).getAttribute("search-template-id");

        $(recordListPanel).setInnerHtml("");
        for (var i = 0; i < data.Data.length; i++) {
            HigLaboVue.append(recordListPanel, templateID, data.Data[i]);
        }
    }
    private record_Click(target: Element, e: Event) {
        this.selectRecord(target);
    }
    private selectRecord(target: Element) {
        const ipl = $(target).getFirstParent("[input-property-panel]").getFirstElement();
        const name = $(ipl).getAttribute("h-record-list");
        const elementType = $(ipl).getAttribute("element-type");
        const mode = $(ipl).getAttribute("select-record-mode");
        const rpl = $(target).getFirstElement();

        switch (mode) {
            case "Html":
                if (elementType == "Record") {
                    const spl = $(ipl).find("[select-record-panel]").getFirstElement();

                    $(spl).setInnerHtml("");
                    spl.appendChild(rpl);
                    $(spl).setFocus();
                    this.closeSearchRecordListPanel(target);
                }
                else if (elementType == "RecordList") {
                    const spl = $(ipl).find("[select-record-list-panel]").getFirstElement();
                    const hKey = $(rpl).getAttribute("h-key");
                    if ($(spl).find("[h-key='" + hKey + "']").getElementCount() > 0) { return false; }
                    spl.appendChild(rpl);
                    spl.scrollTop = 20000;
                }
                break;
            case "Template":
                const templateID = $(ipl).getAttribute("template-id");

                if (elementType == "Record") {
                    const spl = $(ipl).find("[select-record-panel]").getFirstElement();

                    $(rpl).setInnerHtml("");
                    const r = InputPropertyPanel.createRecord(rpl);
                    const pl = HigLaboVue.append(spl, templateID, r);
                    $(spl).setFocus();
                    this.closeSearchRecordListPanel(target);
                }
                else if (elementType == "RecordList") {
                    const spl = $(ipl).find("[select-record-list-panel]").getFirstElement();
                    const hKey = $(rpl).getAttribute("h-key");
                    if ($(spl).find("[h-key='" + hKey + "']").getElementCount() > 0) { return false; }

                    const r = InputPropertyPanel.createRecord(rpl);
                    const pl = HigLaboVue.append(spl, templateID, r)[0];
                    $(pl).setAttribute("toggle-state", "Expand");
                    InputPropertyPanel.setRadioButtonProperty(pl, name, hKey);
                    const checkBoxList = $(pl).find("input[type='checkbox']").getElementList();
                    for (var i = 0; i < checkBoxList.length; i++) {
                        //InputPropertyPanel.setCheckBoxProperty(checkBoxList[i], name, hKey);
                    }
                    spl.scrollTop = 20000;
                }
                break;
            default:
        }
        this.recordAdded(ipl);

        return true;
    }

    private sortButton_Click(target: Element, e: Event) {
        const rpl = $(target).getNearest("[select-record-list-panel]").getFirstElement();
        $(rpl).find("[h-record]").setAttribute("sort-record", "true");

        HigLaboVue.insertBefore(rpl.children[0], "SortLinePanelTemplate", { Text: $(target).getValue() });
        $(rpl).getNearest("[sort-button]").hide();
    }
    private sortRecord_Click(target: Element, e: Event) {
        const rpl = $(target).getParent("[select-record-list-panel]").getFirstElement();
        const linePanel = $(rpl).find("[sort-line-panel]").getFirstElement();
        rpl.insertBefore(target, linePanel);
        $(target).removeAttribute("sort-record");

        if ($(rpl).find("[sort-record]").getElementCount() == 0) {
            linePanel.remove();
            $(rpl).getNearest("[sort-button]").removeStyle("display");
        }
        e.preventDefault();
    }
    private closeButton_Click(target: Element, e: Event) {
        this.closeSearchRecordListPanel(target);
    }
    private closeSearchRecordListPanel(target: Element) {
        const rpl = $(target).getNearestElement("[search-record-list-panel]");
        $(rpl).removeClass("slide-down");
        $(target).getNearest("[button-list-panel]").removeStyle("display");
        $(target).getNearest("[add-record-button]").setFocus();
    }

    private editRecordPanelTextBox_Keyup(target: Element, e: Event) {
        const text = $(target).getValue();
        $(target).getNearest("[header-text]").setInnerText(text);
    }
    private toggleContentPanel_Keydown(target: Element, e: KeyboardEvent) {
        if (e.keyCode == 13) {
            $(target).getParent("[h-record]").toggleAttributeValue("toggle-state", "Expand", "Collapse");
        }
    }
    private toggleContentPanel_Click(target: Element, e: Event) {
        if ($(target).getParentAttribute("can-toggle") == "false") { return; }
        $(target).getParent("[h-record]").toggleAttributeValue("toggle-state", "Expand", "Collapse");
    }
    private headerText_Keydown(target: Element, e: KeyboardEvent) {
        if (e.keyCode == 46) {
            this.deleteCandidate(target);
        }
    }
    private deleteCandidateLink_Click(target: Element, e: Event) {
        this.deleteCandidate(target);
    }
    private deleteCandidate(target: Element) {
        $(target).getParent("[h-record]").toggleAttributeValue("is-delete", "true", "false");
        const v = $(target).getParent("[h-record]").getAttribute("is-delete");
        $(target).getParent("[h-record]").find("input[h-name='IsDelete']").setValue(v);
    }

    public static createRecord(recordElement: Element): any {
        let record: any = {};
        const propertyPanelList = new Array<Element>();
        this.findChildNodes(recordElement, propertyPanelList);
        var name = "";
        for (var i = 0; i < propertyPanelList.length; i++) {
            let propertyPanel = propertyPanelList[i];

            name = $(propertyPanel).getAttribute("h-record-list");
            if (name != "" && record[name] == null) {
                record[name] = this.createRecordList(propertyPanel);
                continue;
            }
            name = $(propertyPanel).getAttribute("h-record");
            if (name != "" && record[name] == null) {
                let r = this.createRecord(propertyPanel);
                record[name] = r;
                continue;
            }
            name = $(propertyPanel).getAttribute("h-name");
            if (name != "" && record[name] == null) {
                InputPropertyPanel.setRecordProperty(record, propertyPanel);
            }
        }
        return record;
    }
    private static setRecordProperty(record: any, propertyPanel: Element) {
        let name = $(propertyPanel).getAttribute("h-name");

        {
            let hRecord = $(propertyPanel).find("[h-record]").getFirstElement();
            if (hRecord != null) {
                record[name] = InputPropertyPanel.createRecord(hRecord);
                return;
            }
        }
        {
            const textarea = $(propertyPanel).find("textarea").getFirstElement() as any;
            if (textarea != null) {
                if (textarea.richTextbox instanceof CKEditorTextBox) {
                    record[name] = (textarea.richTextbox as CKEditorTextBox).getData();
                }
                else if (textarea.richTextbox instanceof TinyMceTextBox) {
                    record[name] = (textarea.richTextbox as TinyMceTextBox).getContent();
                }
                else {
                    record[name] = $(textarea).getValue();
                }
            }
        }
        if ($(propertyPanel).getAttribute("element-type") == "DateDropDownList") {
            const year = $(propertyPanel).find("[year]").getSelectedValue();
            const month = $(propertyPanel).find("[month]").getSelectedValue();
            const day = $(propertyPanel).find("[day]").getSelectedValue();
            record[name] = year + "/" + month + "/" + day;
        }
        else
        {
            const dl = $(propertyPanel).find("select").getFirstElement();
            if (dl != null) {
                record[name] = $(dl).getValue();
                return;
            }
        }
        {
            const radioButtonList = $(propertyPanel).find("input[type='radio']").getElementList();
            for (var i = 0; i < radioButtonList.length; i++) {
                let rb = $(radioButtonList[i]);
                if (rb.isChecked()) {
                    record[name] = rb.getValue();
                    return;
                }
            }
            if (radioButtonList.length > 0) {
                return;
            }
        }
        {
            let element = $(propertyPanel).find("input").getFirstElement();
            if (element == null) {
                if (propertyPanel.tagName.toUpperCase() == "INPUT") {
                    element = propertyPanel;
                }
            }
            if (element == null) { return; }
            let control = $(element);

            switch (control.getAttribute("type")) {
                case "text":
                case "password":
                case "hidden":
                    {
                        let v = control.getValue();
                        if (v != null) {
                            record[name] = v;
                        }
                    }
                    break;
                case "radio":
                    {
                        if (control.isChecked()) {
                            record[name] = control.getValue();
                        }
                    }
                    break;
                case "checkbox":
                    {
                        record[name] = control.isChecked();
                    }
                    break;
                default:
            }
        }
    }
    private static createRecordList(recordListElement: Element): Array<unknown> {
        const rr = new Array<unknown>();
        const recordList = $(recordListElement).find("[h-record]").getElementList();
        for (var i = 0; i < recordList.length; i++) {
            var recordPanel = recordList[i];
            if ($(recordPanel).getParent("[h-record-list]").getFirstElement() != recordListElement) { continue; }
            if ($(recordPanel).getParent("[search-record-list-panel]").getElementCount() > 0) { continue; }
            if ($(recordPanel).getParent("[input-property-panel][element-type='Record']").getElementCount() > 0) { continue; }

            let r = InputPropertyPanel.createRecord(recordPanel);
            rr.push(r);
        }
        return rr;
    }
    private static findChildNodes(element: Element, elementList: Array<Element>): Array<Element> {
        const childList = $(element).getChildElementList();

        for (var i = 0; i < childList.length; i++) {
            var child = childList[i];
            if ($(child).getAttribute("[search-record-list-panel]") != "") { continue; }
            if ($(child).hasAttribute("h-name") ||
                $(child).hasAttribute("h-record") ||
                $(child).hasAttribute("h-record-list")) {
                elementList.push(child);
            }
            else {
                InputPropertyPanel.findChildNodes(child, elementList);
            }
        }
        return elementList;
    }

    public static setElementProperty(recordElement: Element, record: unknown, key: string) {
        const zeroPad2Digits = new Intl.NumberFormat('ja', { minimumIntegerDigits: 2 });
        const propertyList = Object.getOwnPropertyNames(record);

        for (var i = 0; i < propertyList.length; i++) {
            var name = propertyList[i];
            let v = record[name];
            let propertyPanel = $(recordElement).find("[h-name='" + name + "'],[h-record='" + name + "'],[h-record-list='" + name + "']");
            let elementType = propertyPanel.getAttribute("element-type");

            if (elementType == "Color") {
                propertyPanel.find("input").setValue(v);
                propertyPanel.find("[color-panel]").setStyle("background-color", v);
            }
            else if (elementType == "CheckBox") {
                if (key != "") {
                    //InputPropertyPanel.setCheckBoxProperty(propertyPanel.getFirstElement(), name, key);
                }
                propertyPanel.find("input").setChecked(v);
            }
            else if (elementType == "CheckBoxList") {
                const vv = v as Array<any>;
                for (var vIndex = 0; vIndex < vv.length; vIndex++) {
                    let hidden = propertyPanel.find("input[h-name='Value'][value='" + vv[vIndex].Value + "']").getFirstElement();
                    if (hidden == null) { continue; }
                    $(hidden.parentElement).find("input[type='checkbox']").setChecked(vv[vIndex].Checked);
                }
            }
            else if (elementType == "SelectButton" || elementType == "RadioButtonList") {
                if (key != "") {
                    InputPropertyPanel.setRadioButtonProperty(propertyPanel.getFirstElement(), name, key);
                }
                propertyPanel.find("input[type=radio][value='" + v + "']").setChecked(true);
            }
            else if (elementType == "Date") {
                if (v != null) {
                    if (v.Year != null && v.Month != null && v.Day != null) {
                        v = new DateTime(v.Year + "/" + v.Month + "/" + v.Day).toString("yyyy/MM/dd");
                        $(propertyPanel).find("[date-picker]").setValue(v);
                    }
                    else if (v.length > 10) {
                        v = v.replace(/-/g, "/").substr(0, 10);
                        $(propertyPanel).find("[date-picker]").setValue(v);
                    }
                }
            }
            else if (elementType == "DateDropDownList") {
                if (v != null) {
                    if (v.Year != null && v.Month != null && v.Day != null) {
                        $(propertyPanel).find("[year]").setSelectedValue(v.Year);
                        $(propertyPanel).find("[month]").setSelectedValue(v.Month);
                        $(propertyPanel).find("[day]").setSelectedValue(v.Day);
                    }
                    else if (v.length > 10) {
                        v = v.replace(/-/g, "/").substr(0, 10);
                        const date = DateTime.TryCreate(v);
                        if (date != null) {
                            $(propertyPanel).find("[year]").setSelectedValue(date.toString("yyyy"));
                            $(propertyPanel).find("[month]").setSelectedValue(date.toString("MM"));
                            $(propertyPanel).find("[day]").setSelectedValue(date.toString("dd"));
                        }
                    }
                }
            }
            else if (elementType == "Time") {
                if (v != null) {
                    if (v.Hour != null && v.Minute != null && v.Second != null) {
                        v = zeroPad2Digits.format(v.Hour) + ":" + zeroPad2Digits.format(v.Minute) + ":" + zeroPad2Digits.format(v.Second);
                    }
                    else if (v.length > 5) {
                        v = v.replace(/-/g, "/").substr(0, 5);
                    }
                    $(propertyPanel).find("input").setValue(v);
                }
            }
            else if (elementType == "DateTime") {
                if (v != null) {
                    if (v.Date != "") {
                        $(propertyPanel).find("[date-picker]").setValue(v.Date);
                    }
                    if (v.HourMinute != "") {
                        $(propertyPanel).find("[time-picker]").setValue(v.HourMinute);
                    }
                }
            }
            else if (elementType == "DateTimeDuration") {
                InputPropertyPanel.setElementProperty(propertyPanel.getFirstElement(), v, "");
            }
            else if (elementType == "DropDownList") {
                propertyPanel.find("select").setValue(v);
            }
            else if (elementType == "Record") {
                InputPropertyPanel.setRecord(propertyPanel.getFirstElement(), v);
            }
            else if (elementType == "RecordList") {
                InputPropertyPanel.setRecordList(propertyPanel.getFirstElement(), v);
            }
            else {
                let element = propertyPanel.getFirstElement();
                if (element == null) { continue; }

                if (element.tagName.toLowerCase() == "input") {
                    $(element).setValue(v);
                }
                else {
                    let input = propertyPanel.find("input").getFirstElement();
                    switch ($(input).getAttribute("type").toLowerCase()) {
                        case "radio":
                        case "checkbox":
                            $(input).setChecked(v);
                            $(input).triggerEvent("change");
                            break;
                        default:
                            $(input).setValue(v);
                            var textarea = propertyPanel.find("textarea").getFirstElement();
                            if (textarea != null) {
                                this.setTextArea(textarea, v);
                            }
                    }
                }
            }
        }
    }
    private static setRadioButtonProperty(element: Element, name: string, key: string) {
        const radioButtonList = $(element).find("input[type='radio']").getElementList();
        for (var i = 0; i < radioButtonList.length; i++) {
            var rb = radioButtonList[i];
            var rbValue = $(rb).getValue();
            var hName = $(rb).getParentAttribute("h-name");
            var rName = name + "_" + key + "_" + hName;
            $(rb).setAttribute("name", rName);
            $(rb).setAttribute("id", rName + "_" + rbValue);
            $(rb).getNearest("label").setAttribute("for", rName + "_" + rbValue);
        }
    }
    private static setCheckBoxProperty(element: Element, name: string, key: string) {
        const hName = $(element).getAttribute("h-name");
        const id = "CheckBox_" + name + "_" + key + "_" + hName;
        $(element).find("input[type='checkbox']").setAttribute("id", id);
        $(element).find("label").setAttribute("for", id);
    }
    private static setTextArea(element: Element, value: string) {
        let v = value;
        if (v == null) {
            v = "";
        }
        const textarea = element as any;
        if (textarea.richTextbox instanceof CKEditorTextBox) {
            (textarea.richTextbox as CKEditorTextBox).setData(v);
        }
        else if (textarea.richTextbox instanceof TinyMceTextBox) {
            (textarea.richTextbox as TinyMceTextBox).setContent(v);
        }
        else {
            $(textarea).setValue(v);
        }
    }
    private static setRecord(propertyPanel: Element, record: unknown) {
        if (record == null) { return; }
        const selectRecordPanel = $(propertyPanel).find("[select-record-panel]");
        const templateID = propertyPanel.getAttribute("template-id");
        $(selectRecordPanel).setInnerHtml("");
        HigLaboVue.append(selectRecordPanel.getFirstElement(), templateID, record);
    }
    private static setRecordList(propertyPanel: Element, recordList: Array<unknown>) {
        const recordListPanel = $(propertyPanel).find("[select-record-list-panel]").getFirstElement();
        if (recordListPanel == null) { return; }

        const templateID = propertyPanel.getAttribute("template-id");
        $(recordListPanel).setInnerHtml("");
        for (var i = 0; i < recordList.length; i++) {
            var element = HigLaboVue.append(recordListPanel, templateID, recordList[i])[0];
            var key = $(element).getAttribute("h-key");
            InputPropertyPanel.setElementProperty(element, recordList[i], key);
        }
    }

    public static setValidationResult(element: Element, validationResultList: ValidationResult[]) {
        const vv = validationResultList;

        $(element).find("[h-validation-name]").removeClass("fadein");
        setTimeout(function () {
            for (var i = 0; i < vv.length; i++) {
                let vr = vv[i];
                let pl = $("[h-validation-name='" + vr.Name + "']");
                pl.find("[text-panel]").setInnerText(vr.Message);
                pl.addClass("fadein");
            }
        }, 10);
    }
}


export class ValidationResult {
    public Name: string;
    public Message: string;
    public Value: any;
}
export interface RecordAddedEventHandler {
    (sender: InputPropertyPanel, e: RecordAddedEvent): any;
}
export class RecordAddedEvent {
    public InputPropertyPanel: Element;

    constructor(inputPropertyPanel: Element) {
        this.InputPropertyPanel = inputPropertyPanel;
    }
}

