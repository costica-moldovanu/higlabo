﻿import { DateTime } from "./DateTime.js";
import { $, HtmlElementQuery } from "./HtmlElementQuery.js";
import { HttpClient, HttpRequestCallback, HttpResponse } from "./HttpClient.js";
import { List } from "./linq/Collections.js";

export class TinyMceTextBox {
    private tinymce = window["tinymce"];
    private textBox: Element;
    private fileUploadElement: HTMLInputElement;
    private initializeCompletedEventList = new List < (editor) => void> ();

    public createTime = new DateTime(new Date());
    public config: any;
    public editor;
    public fileUploadUrlPath = "";
    public createUploadResultHtml;
    public imageUploadUrlPath = "";
    public imageUploadCallback: HttpRequestCallback;
    public imageUploading: EventListener;
    public CustomCssFilePath = "";

    constructor() {
        this.createUploadResultHtml = this.defaultCreateUploadResultHtml;
        this.initializeConfig();
    }

    private initializeConfig() {
        this.config = {
            height: 600,
            plugins: "print preview powerpaste casechange importcss tinydrive searchreplace autolink save directionality advcode visualblocks visualchars fullscreen "
                + "image link media template codesample table charmap hr pagebreak nonbreaking anchor insertdatetime advlist lists checklist wordcount a11ychecker textpattern "
                //+ "tinycomments mentions "
                + "noneditable help formatpainter permanentpen pageembed charmap quickbars linkchecker emoticons advtable export autoresize",
            mobile: {
                plugins: "print preview powerpaste casechange importcss tinydrive searchreplace autolink save directionality advcode visualblocks visualchars fullscreen "
                    + "image link media template codesample table charmap hr pagebreak nonbreaking anchor insertdatetime advlist lists checklist wordcount a11ychecker textpattern "
                    + "noneditable help formatpainter pageembed charmap mentions quickbars linkchecker emoticons advtable autoresize"
            },
            menubar: "file edit view insert format tools table tc help",
            toolbar: "undo redo | emoticons bold italic underline strikethrough forecolor backcolor charmap | fontselect fontsizeselect formatselect | "
                + "alignleft aligncenter alignright alignjustify | outdent indent | numlist bullist checklist | uploadfile media template link codesample | "
                + "casechange permanentpen removeformat | pagebreak fullscreen  preview print | showcomments addcomment",
            quickbars_insert_toolbar: "emoticons quickimage quicktable",
            quickbars_selection_toolbar: 'bold italic | quicklink h2 h3 h4 blockquote | forecolor backcolor | emoticons quickimage quicktable',
            contextmenu: "link image table configurepermanentpen",

            font_formats: "Andale Mono=andale mono,times;Arial=arial,helvetica,sans-serif;Arial Black=arial black,avant garde;"
                + "Book Antiqua=book antiqua, palatino; Comic Sans MS=comic sans ms, sans- serif;Courier New = courier new, courier; Georgia = georgia, palatino; "
                + "Helvetica = helvetica; Impact = impact, chicago; Symbol = symbol; Tahoma = tahoma, arial, helvetica, sans - serif; Terminal = terminal, monaco;Times "
                + "New Roman = times new roman, times;Trebuchet MS = trebuchet ms, geneva; Verdana = verdana, geneva; Webdings = webdings; Wingdings = wingdings, zapf dingbats",
            fontsize_formats: "8px 10px 12px 14px 16px 18px 20px 24px 32px 36px 48px 64px 72px 96px",

            images_upload_handler: this.imageUpload.bind(this),
            image_caption: true,
            tinydrive_token_provider: "",
            tinydrive_dropbox_app_key: "",
            tinydrive_google_drive_key: "",
            tinydrive_google_drive_client_id: "",
            menu: {
                tc: {
                    title: 'Comments',
                    items: 'addcomment showcomments deleteallconversations'
                }
            },

            autosave_ask_before_unload: false,
            //autosave_interval: '30s',
            //autosave_prefix: '{path}{query}-{id}-',
            //autosave_restore_when_empty: false,
            //autosave_retention: '2m',
            image_advtab: true,
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
            link_list: [
                //    { title: 'My page 1', value: 'https://www.tiny.cloud' },
                //    { title: 'My page 2', value: 'http://www.moxiecode.com' }
            ],
            image_list: [
                //    { title: 'My page 1', value: 'https://www.tiny.cloud' },
                //    { title: 'My page 2', value: 'http://www.moxiecode.com' }
            ],
            image_class_list: [
                //    { title: 'None', value: '' },
                //    { title: 'Some class', value: 'class-name' }
            ],
            importcss_append: true,
            templates: [
                //    { title: 'New Table', description: 'creates a new table', content: '<div class="mceTmpl"><table width="98%%"  border="0" cellspacing="0" cellpadding="0"><tr><th scope="col"> </th><th scope="col"> </th></tr><tr><td> </td><td> </td></tr></table></div>' },
                //    { title: 'Starting my story', description: 'A cure for writers block', content: 'Once upon a time...' },
                //    { title: 'New list with dates', description: 'New List with dates', content: '<div class="mceTmpl"><span class="cdate">cdate</span><br /><span class="mdate">mdate</span><h2>My List</h2><ul><li></li><li></li></ul></div>' }
            ],
            template_cdate_format: '[Created at: %m/%d/%Y : %H:%M:%S]',
            template_mdate_format: '[Modified at: %m/%d/%Y : %H:%M:%S]',

            default_link_target: "_blank",
            extended_valid_elements: "a[href|target=_blank]",

            smart_paste : false,
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

                editor.ui.registry.addButton("uploadfile", {
                    tooltip: "File Upload",
                    icon: "upload",
                    onAction: function (e) {
                        this.fileUploadElement.click();
                    }.bind(this)
                });
            }.bind(this),

            init_instance_callback: function (editor) {
                for (var i = 0; i < this.initializeCompletedEventList.count(); i++) {
                    let f = this.initializeCompletedEventList.get(i);
                    f(editor);
                }
            }.bind(this)
        };
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

    public initialize(textBox: Element) {
        this.remove();
        if (textBox == null) { return; }

        this.textBox = textBox as Element;
        (this.textBox as any).richTextbox = this;
        this.config.target = textBox;
        if (this.CustomCssFilePath != "") {
            this.addInitializeCompletedEventHandler(this.addCustomeCssFileLinkElement.bind(this));
        }
        this.tinymce.init(this.config);
    }
    private addCustomeCssFileLinkElement(editor) {
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
        HttpClient.postForm(this.fileUploadUrlPath, formData, this.fileUploadCallback.bind(this), this.fileUploadErrorCallback.bind(this));
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
    private fileUploadErrorCallback(response: HttpResponse) {

    }
    private imageUpload(blobInfo, success, failure, progress) {
        if (this.imageUploadUrlPath == "") { return; }
        var formData = new FormData();
        formData.append('file', blobInfo.blob(), blobInfo.filename());
        HttpClient.postForm(this.imageUploadUrlPath, formData
            , this.invokeImageUploadCallback.bind(this)
            , this.invokeImageUploadCallback.bind(this)
            , this.invokeImageUploadProgress.bind(this)
            , {
                success: success,
                failure: failure
            }
        );
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

    public addInitializeCompletedEventHandler(func: (editor) => void) {
        this.initializeCompletedEventList.push(func);
    }

    public setContent(value: string) {
        if (this.editor != null) {
            this.tinymce.activeEditor.setContent(value.replace("\r", ""));
        }
    }
    public setTextAreaValue(value) {
        if (this.textBox != null) {
            $(this.textBox).setValue(value);
        }
    }
    public setFocus() {
        if (this.editor == null) { return $(this.textBox).setFocus(); }
        this.editor.focus();
    }

    public getContent() {
        return this.tinymce.activeEditor.getContent();
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


