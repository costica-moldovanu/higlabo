# higlabo
HigLabo library provide features 

1. OpenAI client library
2. Object Mapper(fastest in the world)
3. DbSharp(DAL generator)
4. And other.(Mail, Ftp, Rss, Twitter...etc)

I added .NET Standard version at 2020/07/03.
It was moved from https://github.com/higty/higlabo.netstandard repository.

## HigLabo.OpenAI
A client library for OpenAI API (including assistants endpoint that opened 2023.11.06 at OpenAI event)
https://www.codeproject.com/Articles/5372480/Csharp-OpenAI-library-that-support-Assistants-API

## HigLabo.Mapper
A mapper library like AutoMapper,EmitMapper,FastMapper,ExpressMapper..etc.
I posted article to CodeProject.
https://www.codeproject.com/Articles/5275388/HigLabo-Mapper-Creating-Fastest-Object-Mapper-in-t

You can map object out of box without configuration.
You can also customize completely as you can with AddPostAction,ReplaceMap method.

I completely rewrite HigLabo.Mapper. Now, HigLabo.Mapper is fastest mapper library in the world.

Performance test at 2024/02/02.
![image](https://github.com/higty/higlabo/assets/10071037/a739220e-605f-44dd-bf60-b0d4784fe76c)
Note) Mapperly is fast because it does not create new instance. That only pass reference. It does not map property values. Mapperly looks fastest but it is not on the test Address, Customer.
HigLabo.Mapper is fastest than any other library. Only Address to AddressDTO is slower than Mapperly.


HigLabo.Mapper (version3.0.0 or later) is used expression tree. It generate il code on runtime, so it is nealy fast as handy code.


## DbSharp
A code generator to call stored procedure on database(SQL server, MySQL)

https://www.codeproject.com/Articles/776811/DbSharp-DAL-Generator-Tool-on-NET-Core

## HigLabo.Mime
A library of Mime parser. Fastest parser in the world for MIME format. It is used for HigLabo.Mail.

## HigLabo.Mail
A mail library of SMTP,POP3,IMAP.

https://www.codeproject.com/Articles/399207/Understanding-the-Insides-of-the-SMTP-Mail-Protoco
https://www.codeproject.com/Articles/404066/Understanding-the-insides-of-the-POP-mail-protoco
https://www.codeproject.com/Articles/411018/Understanding-the-insides-of-the-IMAP-mail-protoco

## HigLabo.Data.XXX
A library for database access.

## HigLabo.Converter
Converter library for Base64,QueryString,QuotedPrintable,Rfc2047,ModifiedUtf7,ISO8601...etc.

## HigLabo.Net.Slack
Slack client library to call Slack API.
https://www.codeproject.com/Articles/5336184/Creating-best-Csharp-Slack-client-library-in-the-w

