﻿import { DateTime } from "./DateTime.js";
import { HigLaboVue } from "./HigLaboVue.js";
import { $, HtmlElementQuery } from "./HtmlElementQuery.js";
import { HttpClient, HttpRequestCallback, HttpResponse } from "./HttpClient.js";
import { InputPropertyPanel } from "./InputPropertyPanel.js";
import { List } from "./linq/Collections.js";

export class TinyMceTextBox {
    private tinymce = window["tinymce"];
    private fileUploadElement: HTMLInputElement;
    public setupCompletedEventList = new List<(textbox: TinyMceTextBox) => void>();
    public initializeCompletedEventList = new List<(textbox: TinyMceTextBox) => void>();

    public textBox: Element;
    public createTime = new DateTime(new Date());
    public config: any;
    public editor;
    public fileUploadUrlPath = "";
    public createUploadResultHtml;
    public imageUploadUrlPath = "";
    public imageUploadCallback: HttpRequestCallback;
    public imageUploading: EventListener;
    public mentionListPopupPanel = document.getElementById("MentionListPopupPanel");
    public apiPathMention = "";
    public CustomCssFilePath = "";

    constructor() {
        this.createUploadResultHtml = this.defaultCreateUploadResultHtml;
        this.initializeConfig();
    }

    public initialize(textBox: Element) {
        if (this.tinymce == null) { return; }
        this.remove();
        if (textBox == null) { return; }

        this.textBox = textBox as Element;
        (this.textBox as any).richTextbox = this;
        this.config.target = textBox;
        if (this.apiPathMention != "") {
            this.initializeCompletedEventList.push(this.registerShowMentionListPopupPanel.bind(this));
        }
        if (this.CustomCssFilePath != "") {
            this.initializeCompletedEventList.push(this.addCustomeCssFileLinkElement.bind(this));
        }
        this.tinymce.init(this.config);
    }

    private initializeConfig() {
        this.config = {
            height: 600,
            plugins: ["preview", "importcss", "searchreplace", "save", "directionality", "visualblocks", "visualchars", "fullscreen"
                , "image", "link", "media", "codesample", "table", "charmap", "pagebreak", "nonbreaking", "anchor"
                , "insertdatetime", "advlist", "lists", "wordcount", "help", "charmap", "quickbars", "emoticons", "autoresize"],
            mobile: {
                plugins: ["preview", "casechange", "importcss", "searchreplace", "save", "directionality", "visualblocks", "visualchars", "fullscreen"
                    , "image", "link", "media", "codesample", "table", "charmap", "pagebreak", "nonbreaking", "anchor"
                    , "insertdatetime", "advlist", "lists", "wordcount", "help", "charmap", "quickbars", "emoticons", "autoresize"]
            },
            menubar: "file edit view insert format tools table tc help",
            toolbar: "undo redo | uploadfile media link | emoticons bold italic underline strikethrough forecolor backcolor charmap | fontfamily fontsize styles | "
                + "alignleft aligncenter alignright alignjustify | outdent indent | numlist bullist | "
                + "casechange removeformat | pagebreak fullscreen  preview print | showcomments addcomment",
            quickbars_insert_toolbar: "emoticons quickimage quicktable",
            quickbars_selection_toolbar: 'bold italic | quicklink h2 h3 h4 h5 h6 blockquote | forecolor backcolor | emoticons quickimage quicktable',
            contextmenu: "link image table",

            font_formats: "Andale Mono=andale mono,times;Arial=arial,helvetica,sans-serif;Arial Black=arial black,avant garde;"
                + "Book Antiqua=book antiqua, palatino; Comic Sans MS=comic sans ms, sans- serif;Courier New = courier new, courier; Georgia = georgia, palatino; "
                + "Helvetica = helvetica; Impact = impact, chicago; Symbol = symbol; Tahoma = tahoma, arial, helvetica, sans - serif; Terminal = terminal, monaco;Times "
                + "New Roman = times new roman, times;Trebuchet MS = trebuchet ms, geneva; Verdana = verdana, geneva; Webdings = webdings; Wingdings = wingdings, zapf dingbats",
            fontsize_formats: "8px 10px 12px 14px 16px 18px 20px 24px 32px 36px 48px 64px 72px 96px",

            images_upload_handler: this.imageUpload.bind(this),
            images_reuse_filename: true,
            image_caption: true,

            autosave_ask_before_unload: false,
            codesample_languages: [
                { value: "plaintext", text: "Plain text" }, // The default language.
                { value: "html", text: "HTML" },
                { value: "xml", text: "HTML/XML" },
                { value: "css", text: "CSS" },
                { value: "json", text: "JSON" },
                { value: "javascript", text: "JavaScript" },
                { value: "typescript", text: "TypeScript" },
                { value: "sql", text: "SQL" },
                { value: "graphql", text: "GraphQL" },
                { value: "c", text: "C" },
                { value: "cpp", text: "C++" },
                { value: "csharp", text: "C#" },
                { value: "java", text: "Java" },
                { value: "php", text: "PHP" },
                { value: "python", text: "Python" },
                { value: "ruby", text: "Ruby" },
                { value: "php", text: "PHP" },
                { value: "kotlin", text: "Kotlin" },
                { value: "go", text: "GO" },
                { value: "swift", text: "Swift" },
                { value: "bash", text: "Bash" },
                { value: "powershell", text: "PowerShell" },
                { value: "docker", text: "Docker" },
                { value: "yaml", text: "YAML" },
                { value: "diff", text: "Diff" },
            ],
            importcss_append: true,
            autolink_pattern: /^(https?:\/\/|ssh:\/\/|ftp:\/\/|file:\/|www\.|(?:mailto:)?[A-Z0-9._%+\-]+@)(.+)$/i,
            default_link_target: "_blank",

            smart_paste: false,
            indentation: "16px",
            indent_use_margin: true,
            noneditable_noneditable_class: 'mceNonEditable',
            toolbar_mode: 'sliding',
            spellchecker_ignore_list: ['Ephox', 'Moxiecode'],
            tinycomments_mode: "embedded",
            tinycomments_author: "",
            content_style: '.mymention{ color: gray; }',
            a11y_advanced_options: true,
            skin: 'oxide',
            content_css: 'default',
            color_cols: 10,

            mentions_selector: "",
            mentions_min_chars: 1,
            mentions_fetch: null,
            mentions_menu_hover: null,
            mentions_menu_complete: null,
            mentions_select: null,
            mentions_item_type: "profile",


            setup: function (editor) {
                this.editor = editor;
                this.initializeFileUploadElement(editor);
                editor.on('keyup', function (e) {
                    this.savePreviousValue(e);
                }.bind(this));

                editor.ui.registry.addButton("uploadfile", {
                    tooltip: "File Upload",
                    icon: "upload",
                    onAction: function (e) {
                        this.fileUploadElement.click();
                    }.bind(this)
                });
                this.setupCompletedEventList_Invoke();
            }.bind(this),

            init_instance_callback: function (editor) {
                this.setContent($(this.textBox).getValue());
                this.initializeCompletedEventList_Invoke();
            }.bind(this)
        };
    }
    private setupCompletedEventList_Invoke() {
        for (var i = 0; i < this.setupCompletedEventList.count(); i++) {
            let f = this.setupCompletedEventList.get(i);
            f(this);
        }
    }
    private initializeCompletedEventList_Invoke() {
        for (var i = 0; i < this.initializeCompletedEventList.count(); i++) {
            let f = this.initializeCompletedEventList.get(i);
            f(this);
        }
    }
    private initializeFileUploadElement(editor) {
        const pl = $(editor.getElement()).getParentElementList()[0] as HTMLElement;
        const fd = document.createElement("input") as HTMLInputElement;
        fd.type = "file";
        $(fd).setStyle("display", "none");
        pl.appendChild(fd);
        $(fd).change(this.fileSelected.bind(this));
        this.fileUploadElement = fd;
    }

    private addCustomeCssFileLinkElement(textbox: TinyMceTextBox) {
        const editor = textbox.editor;
        const iframe = $(editor.getElement().parentElement).find("iframe").getFirstElement() as HTMLIFrameElement;
        const iframeDocument = iframe.contentWindow.document;
        if (iframeDocument.getElementById("TinyMceCss") != null) { return; }

        const head = $(iframeDocument).find("head").getFirstElement();
        const link = iframeDocument.createElement("link");
        link.id = "TinyMceCss";
        $(link).setAttribute("rel", "stylesheet");
        $(link).setAttribute("type", "text/css");
        $(link).setAttribute("href", this.CustomCssFilePath);
        head.appendChild(link);
    }

    private fileSelected(e: Event) {
        if (this.fileUploadUrlPath == "") { return; }
        const f = this.fileUploadElement;
        const formData = new FormData();
        for (var i = 0; i < f.files.length; i++) {
            formData.append(f.name, f.files[i]);
        }
        HttpClient.postForm(this.fileUploadUrlPath, formData, this.fileUploadCallback.bind(this));
        $(f).setValue("");
    }
    private fileUploadCallback(response: HttpResponse) {
        if (this.createUploadResultHtml != null) {
            const html = this.createUploadResultHtml(response);
            this.editor.insertContent(html);
        }
    }
    private defaultCreateUploadResultHtml(response: HttpResponse) {
        const data = response.jsonParse();
        const l = new List<any>();
        if (data instanceof Array) {
            for (var i = 0; i < data.length; i++) {
                l.push(data[i]);
            }
        }
        else {
            l.push(data);
        }

        let html = "";
        for (var i = 0; i < l.count(); i++) {
            let r = l.get(i);
            if (r.IsImage == true) {
                html += "<a class=\"upload-file-link\" href=\"" + r.Url + "\" target=\"_blank\"><img src=\"" + r.Url + "\" /></a><br />";
            }
            else {
                html += "<a class=\"upload-file-link\" href=\"" + r.Url + "\" target=\"_blank\">" + r.FileName + "</a><br />";
            }
        }
        return html;
    }
    private imageUpload(blobInfo, progress) {
        return new Promise((resolve, reject) => {
            if (this.imageUploadUrlPath == "") { return; }
            var formData = new FormData();
            formData.append('file', blobInfo.blob(), blobInfo.filename());
            HttpClient.postForm(this.imageUploadUrlPath, formData
                , this.invokeImageUploadCallback.bind(this)
                , this.invokeImageUploadCallback.bind(this)
                , this.invokeImageUploadProgress.bind(this)
                , {
                    success: resolve,
                    failure: reject
                }
            );
        });
    }
    private invokeImageUploadCallback(response: HttpResponse, context: any) {
        const result = response.getWebApiResult();
        const success = context.success;
        success(result.Data.ImageUrl);
        if (this.imageUploadCallback != null) {
            this.imageUploadCallback(response, context);
        }
    }
    private invokeImageUploadProgress(e: Event) {
        if (this.imageUploading != null) {
            this.imageUploading(e);
        }
    }

    private registerShowMentionListPopupPanel(textbox: TinyMceTextBox) {
        const editor = textbox.editor;
        editor.on("keydown", function (e) { this.tinyMceTextArea_Keydown(textbox, e) }.bind(this));
        editor.on("keyup", function (e) { this.tinyMceTextArea_Keyup(textbox, e) }.bind(this));
    }
    public selectMention(panel: Element) {
        const pl = panel;
        const rMention = InputPropertyPanel.createRecord(pl);
        rMention.DisplayName = "@" + rMention.DisplayName;

        const pTag = this.editor.selection.getNode() as HTMLElement;
        $(pTag).setInnerText(rMention.DisplayName);
        this.select(pTag);
        this.collapse(false);

        $(this.mentionListPopupPanel).hide();
    }
    private tinyMceTextArea_Keydown(textbox: TinyMceTextBox, e: KeyboardEvent) {
        const pTag = textbox.editor.selection.getNode() as HTMLElement;
        const div = $(textbox.textBox).getNearest("div[role='application'].tox-tinymce").getFirstElement();
        const ppl = this.mentionListPopupPanel;
        const currentMentionPanel = $(ppl).find(".current").getFirstElement();

        let mpl: Element;
        let isKeydown = false;
        if ($(ppl).getStyle("display") == "block") {
            if (e.keyCode == 13) {
                this.selectMention(currentMentionPanel);
                const mentionTag = $(pTag).getSibling("Previous").getLastElement();
                mentionTag.remove();
                e.preventDefault();
                return;
            }
            else if (e.keyCode == 38) {
                isKeydown = true;
                if (currentMentionPanel == null) {
                    mpl = $(ppl).find("[mention-record-panel]").getLastElement();
                }
                else {
                    mpl = $(currentMentionPanel).getSibling("Previous").getLastElement();
                }
            }
            else if (e.keyCode == 40) {
                isKeydown = true;
                if (currentMentionPanel == null) {
                    mpl = $(ppl).find("[mention-record-panel]").getFirstElement();
                }
                else {
                    mpl = $(currentMentionPanel).getSibling("Next").getFirstElement();
                }
            }
            if (isKeydown == true) {
                $(ppl).find(".current").removeClass("current");
                if (mpl == null) {
                    $(pTag).setInnerHtml("@" + $(ppl).getAttribute("search-text"));
                }
                else {
                    $(mpl).addClass("current");
                }
                e.preventDefault();
                return;
            }
        }
        if (isKeydown == false) {
            if (e.keyCode < 47) {
                $(ppl).hide();
            }
        }
        window["tinymce_current"] = this;
    }
    private tinyMceTextArea_Keyup(textbox: TinyMceTextBox, e: KeyboardEvent) {
        if (e.keyCode < 47) { return; }

        const pTag = textbox.editor.selection.getNode() as HTMLElement;
        const div = $(textbox.textBox).getNearest("div[role='application'].tox-tinymce").getFirstElement();
        const iframe = $(div).find("iframe").getFirstElement();
        const ppl = document.getElementById("MentionListPopupPanel");

        const text = pTag.innerHTML;

        if (text.startsWith("@") == false) { return; }
        const searchText = text.substr(1);
        this.searchMentionUserList(searchText);

        const iframeRect = iframe.getBoundingClientRect();
        const pRect = pTag.getBoundingClientRect();

        $(ppl).setStyle("display", "block");
        $(ppl).setStyle("left", (iframeRect.left + pRect.left) + "px");
        $(ppl).setStyle("top", (iframeRect.top + pRect.top + 28) + "px");
    }
    public createLoadMentionListParameter(): any {
        return {};
    }
    private searchMentionUserList(searchText) {
        let p = this.createLoadMentionListParameter();
        p.SearchText = searchText;
        HttpClient.postJson(this.apiPathMention, p, this.searchMentionUserListCallback.bind(this));
        const ppl = document.getElementById("MentionListPopupPanel");
        $(ppl).hide();
        $(ppl).setAttribute("search-text", searchText);
    }
    private searchMentionUserListCallback(response: HttpResponse) {
        const result = response.getWebApiResult();
        const ppl = document.getElementById("MentionListPopupPanel");
        const rr = result.Data as Array<any>;

        $(ppl).setInnerHtml("");
        for (var i = 0; i < rr.length; i++) {
            HigLaboVue.append(ppl, "MentionRecordPanel", rr[i]);
        }
        if (rr.length == 0) {
            $(ppl).hide();
        }
    }

    public setFocus() {
        if (this.editor == null) { return $(this.textBox).setFocus(); }
        this.editor.focus();
    }
    public setCursorLocation(node: Node, offset: Number) {
        if (this.editor == null) { return; }
        this.tinymce.activeEditor.selection.setCursorLocation(node, offset);
    }
    public select(node: Node) {
        if (this.editor == null) { return; }
        this.tinymce.activeEditor.selection.select(node);
    }
    public collapse(collapse: boolean) {
        if (this.editor == null) { return; }
        this.tinymce.activeEditor.selection.collapse(collapse);
    }
    public getBookmark() {
        if (this.editor == null) { return; }
        this.tinymce.activeEditor.selection.getBookmark();
    }
    public moveToBookmark(bookmark) {
        if (this.editor == null) { return; }
        this.tinymce.activeEditor.selection.moveToBookmark(bookmark);
    }

    public setTextAreaValue(value) {
        if (this.textBox != null) {
            $(this.textBox).setValue(value);
        }
    }
    public setContent(value: string) {
        if (this.editor != null) {
            this.editor.setContent(value.replace("\r", ""));
        }
    }
    public getContent() {
        return this.editor.getContent();
    }
    public getInnerHtml() {
        const iframe = $(this.textBox).getNearest("iframe").getFirstElement() as HTMLIFrameElement;
        const body = $(iframe.contentWindow.document).find("body").getFirstElement();
        var text = $(body).getInnerHtml();
        if (text == "<p><br data-mce-bogus=\"1\"></p>") {
            text = "";
        }
        return text;
    }
    public getPreviousInnerHtml() {
        const iframe = $(this.textBox).getNearest("iframe").getFirstElement() as HTMLIFrameElement;
        const body = $(iframe.contentWindow.document).find("body").getFirstElement();
        return $(body).getAttribute("previous-value");
    }
    private savePreviousValue(e: KeyboardEvent) {
        $(e.target).setAttribute("previous-value", this.getInnerHtml());
    }

    public remove() {
        if (this.textBox != null) {
            $(this.textBox).getSibling("Next").remove();
            $(this.textBox).removeStyle("display");

            this.textBox = null;
            this.config.target = null;
        }
    }
}


