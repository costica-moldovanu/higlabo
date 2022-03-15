﻿import { List } from "./linq/Linq.js";
import { DateTime } from "./DateTime.js";
import { $ } from "./HtmlElementQuery.js";

export class HigLaboVue {
    public static formatMethods = {
        numberFormat: HigLaboVue.numberFormat,
        currencyFormat: HigLaboVue.currencyFormat,
        dateFormat: HigLaboVue.dateFormat,
        encodeURI: HigLaboVue.encodeURI,
        encodeURIComponent: HigLaboVue.encodeURIComponent,
        decodeURI: HigLaboVue.decodeURI,
        decodeURIComponent: HigLaboVue.decodeURIComponent,
    };
    public static defaultSettings = {
        culture: "ja-JP",
        currency: "JPY",
    }

    private static createApp(templateID: string, data: any) {
        var template = document.getElementById(templateID);
        if (template == null) { throw new Error("Template not found. id is " + templateID); }
        const app = window["Vue"].createApp({
            data() { return data; },
            template: template.innerHTML,
            methods: HigLaboVue.formatMethods
        });
        return app;
    }
    public static create(templateID: string, data: any): Array<Element> {
        //Add dummy element to body to ensure createApp works.
        document.body.insertBefore(document.createElement("div"), document.body.firstChild);
        const dummyElement = document.body.firstChild;

        const app = HigLaboVue.createApp(templateID, data);
        app.mount(dummyElement);

        //Remove [data-v-app] element and replace it.
        const elementList = $(dummyElement.parentElement).find("[data-v-app]").getElementList();
        const createdElementList = new List<Element>();
        for (var i = 0; i < elementList.length; i++) {
            var element = elementList[i];
            while (element.children.length > 0) {
                var actualElement = element.children[0];
                HigLaboVue.appendChild(actualElement, data);
                createdElementList.push(actualElement);
                actualElement.remove();
            }
        }
        dummyElement.remove();
        return createdElementList.toArray();
    }
    public static render(element: Element, templateID: string, data: any): Array<Element> {
        $(element).setInnerHtml("");
        const l = HigLaboVue.create(templateID, data);
        for (var i = 0; i < l.length; i++) {
            element.append(l[i]);
        }
        return l;
    }
    public static append(element: Element, templateID: string, data: any): Array<Element> {
        const l = HigLaboVue.create(templateID, data);
        for (var i = 0; i < l.length; i++) {
            element.append(l[i]);
        }
        return l;
    }
    public static insertBefore(targetElement: Element, templateID: string, data: any): Array<Element> {
        return this.processElement(targetElement.parentElement, targetElement, templateID, data);
    }
    private static processElement(element: Element, targetElement: Element, templateID: string, data: any): Array<Element> {
        if (element == null) { throw new Error("element must not be null."); }

        const span = document.createElement("span") as HTMLElement;
        element.appendChild(span);//Dummy element

        const app = HigLaboVue.createApp(templateID, data);
        app.mount(span);

        //Remove Dummy element and replace it.
        const elementList = $(element).find("[data-v-app]").getElementList();
        const createdElementList = new List<Element>();
        for (var i = 0; i < elementList.length; i++) {
            var element = elementList[i];
            while (element.children.length > 0) {
                var actualElement = element.children[0];
                if (targetElement == null) {
                    element.parentElement.append(actualElement);
                }
                else {
                    element.parentElement.insertBefore(actualElement, targetElement);
                }
                HigLaboVue.appendChild(actualElement, data);
                createdElementList.push(actualElement);
            }
            element.remove();
        }
        return createdElementList.toArray();
    }
    private static appendChild(element: Element, data: any) {
        const templateList = $(element).find("[template-name]").getElementList();
        for (var i = 0; i < templateList.length; i++) {
            var pl = $(templateList[i]);
            var templateID = pl.getAttribute("template-name");
            if (templateID == "") { continue; }

            var name = pl.getAttribute("property-name");

            var r = data[name];
            if (r == null && name == "this") {
                r = data;
            }
            if (r != null) {
                if (r instanceof Array) {
                    for (var rIndex = 0; rIndex < r.length; rIndex++) {
                        HigLaboVue.append(templateList[i], templateID, r[rIndex]);
                    }
                }
                else {
                    HigLaboVue.append(templateList[i], templateID, r);
                }
                pl.removeAttribute("template-name");
            }
        }
    }

    public static numberFormat(value, culture: string) {
        if (value == null) { return ""; }
        if (culture == null) { culture = HigLaboVue.defaultSettings.culture; }
        const f = new Intl.NumberFormat(culture);
        return f.format(value);
    }
    public static currencyFormat(value, culture: string, currency: string) {
        if (value == null) { return ""; }
        if (culture == null) { culture = HigLaboVue.defaultSettings.culture; }
        if (currency == null) { currency = HigLaboVue.defaultSettings.currency; }
        const f = new Intl.NumberFormat(culture, {
            style: "currency",
            currency: currency
        });
        return f.format(value);
    }
    public static dateFormat(value, format: string) {
        if (value == null) { return ""; }
        return new DateTime(value).toString(format);
    }
    public static encodeURI(value) {
        if (value == null) { return ""; }
        return encodeURI(value);
    }
    public static encodeURIComponent(value) {
        if (value == null) { return ""; }
        return encodeURIComponent(value);
    }
    public static decodeURI(value) {
        if (value == null) { return ""; }
        return decodeURI(value);
    }
    public static decodeURIComponent(value) {
        if (value == null) { return ""; }
        return decodeURIComponent(value);
    }

}

