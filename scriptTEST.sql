USE [Test]
GO
/****** Object:  Table [dbo].[tblConfig]    Script Date: 24/9/2022 17:07:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblConfig](
	[ConfigID] [int] IDENTITY(1,1) NOT NULL,
	[NameKey] [varchar](50) NOT NULL,
	[KeyValue] [varchar](150) NOT NULL,
 CONSTRAINT [PK_tblConfig] PRIMARY KEY CLUSTERED 
(
	[ConfigID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblMessages]    Script Date: 24/9/2022 17:07:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblMessages](
	[MessageID] [int] IDENTITY(1,1) NOT NULL,
	[DateCreated] [datetime] NOT NULL,
	[ToNumber] [varchar](50) NOT NULL,
	[Message] [varchar](500) NOT NULL,
 CONSTRAINT [PK_tblMessages] PRIMARY KEY CLUSTERED 
(
	[MessageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblMessagesSend]    Script Date: 24/9/2022 17:07:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblMessagesSend](
	[MessageSendID] [int] IDENTITY(1,1) NOT NULL,
	[MessageID] [int] NOT NULL,
	[DateSent] [datetime] NOT NULL,
	[ConfirmatedCode] [varchar](50) NOT NULL,
	[ResponseJSON] [varchar](8000) NULL,
 CONSTRAINT [PK_tblMessageSend] PRIMARY KEY CLUSTERED 
(
	[MessageSendID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tblConfig] ON 

INSERT [dbo].[tblConfig] ([ConfigID], [NameKey], [KeyValue]) VALUES (1, N'accountSid', N'ACc69c1a91e3414f30edc24ab30973b1a9')
INSERT [dbo].[tblConfig] ([ConfigID], [NameKey], [KeyValue]) VALUES (2, N'authToken', N'9c30855abd19a61f4a11b39a2ddb50dc')
INSERT [dbo].[tblConfig] ([ConfigID], [NameKey], [KeyValue]) VALUES (3, N'messagingServiceSid', N'MG4c3641885324df1a1f1a2d47f3b6442d')
SET IDENTITY_INSERT [dbo].[tblConfig] OFF
GO
SET IDENTITY_INSERT [dbo].[tblMessages] ON 

INSERT [dbo].[tblMessages] ([MessageID], [DateCreated], [ToNumber], [Message]) VALUES (20, CAST(N'2022-09-24T14:23:35.320' AS DateTime), N'+50377425139', N'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic')
INSERT [dbo].[tblMessages] ([MessageID], [DateCreated], [ToNumber], [Message]) VALUES (21, CAST(N'2022-09-24T14:37:45.103' AS DateTime), N'+50377425139', N'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic')
INSERT [dbo].[tblMessages] ([MessageID], [DateCreated], [ToNumber], [Message]) VALUES (22, CAST(N'2022-09-24T15:15:13.340' AS DateTime), N'+50377425139', N'is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesettin')
INSERT [dbo].[tblMessages] ([MessageID], [DateCreated], [ToNumber], [Message]) VALUES (23, CAST(N'2022-09-24T15:28:49.567' AS DateTime), N'+50377425139', N'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic')
SET IDENTITY_INSERT [dbo].[tblMessages] OFF
GO
SET IDENTITY_INSERT [dbo].[tblMessagesSend] ON 

INSERT [dbo].[tblMessagesSend] ([MessageSendID], [MessageID], [DateSent], [ConfirmatedCode], [ResponseJSON]) VALUES (6, 20, CAST(N'2022-09-24T14:23:38.000' AS DateTime), N'ACc69c1a91e3414f30edc24ab30973b1a9', N'{
  "Body": "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry\u0027s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic",
  "NumSegments": "0",
  "Direction": {},
  "From": {},
  "To": "\u002B50377425139",
  "DateUpdated": "2022-09-24T14:23:38-06:00",
  "Uri": "/2010-04-01/Accounts/ACc69c1a91e3414f30edc24ab30973b1a9/Messages/SMd429dafd2d4af613b89231a28bc57929.json",
  "AccountSid": "ACc69c1a91e3414f30edc24ab30973b1a9",
  "NumMedia": "0",
  "Status": {},
  "MessagingServiceSid": "MG4c3641885324df1a1f1a2d47f3b6442d",
  "Sid": "SMd429dafd2d4af613b89231a28bc57929",
  "DateCreated": "2022-09-24T14:23:38-06:00",
  "ApiVersion": "2010-04-01",
  "SubresourceUris": {
    "media": "/2010-04-01/Accounts/ACc69c1a91e3414f30edc24ab30973b1a9/Messages/SMd429dafd2d4af613b89231a28bc57929/Media.json"
  }
}')
INSERT [dbo].[tblMessagesSend] ([MessageSendID], [MessageID], [DateSent], [ConfirmatedCode], [ResponseJSON]) VALUES (7, 21, CAST(N'2022-09-24T14:37:48.000' AS DateTime), N'ACc69c1a91e3414f30edc24ab30973b1a9', N'{
  "Body": "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry\u0027s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic",
  "NumSegments": "0",
  "Direction": {},
  "From": {},
  "To": "\u002B50377425139",
  "DateUpdated": "2022-09-24T14:37:48-06:00",
  "Uri": "/2010-04-01/Accounts/ACc69c1a91e3414f30edc24ab30973b1a9/Messages/SMeed0d919767da853afc3ff815a044895.json",
  "AccountSid": "ACc69c1a91e3414f30edc24ab30973b1a9",
  "NumMedia": "0",
  "Status": {},
  "MessagingServiceSid": "MG4c3641885324df1a1f1a2d47f3b6442d",
  "Sid": "SMeed0d919767da853afc3ff815a044895",
  "DateCreated": "2022-09-24T14:37:48-06:00",
  "ApiVersion": "2010-04-01",
  "SubresourceUris": {
    "media": "/2010-04-01/Accounts/ACc69c1a91e3414f30edc24ab30973b1a9/Messages/SMeed0d919767da853afc3ff815a044895/Media.json"
  }
}')
INSERT [dbo].[tblMessagesSend] ([MessageSendID], [MessageID], [DateSent], [ConfirmatedCode], [ResponseJSON]) VALUES (8, 22, CAST(N'2022-09-24T15:15:16.000' AS DateTime), N'ACc69c1a91e3414f30edc24ab30973b1a9', N'{
  "Body": "is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry\u0027s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesettin",
  "NumSegments": "0",
  "Direction": {},
  "From": {},
  "To": "\u002B50377425139",
  "DateUpdated": "2022-09-24T15:15:16-06:00",
  "Uri": "/2010-04-01/Accounts/ACc69c1a91e3414f30edc24ab30973b1a9/Messages/SM50e04235c896af83798671664cba05d8.json",
  "AccountSid": "ACc69c1a91e3414f30edc24ab30973b1a9",
  "NumMedia": "0",
  "Status": {},
  "MessagingServiceSid": "MG4c3641885324df1a1f1a2d47f3b6442d",
  "Sid": "SM50e04235c896af83798671664cba05d8",
  "DateCreated": "2022-09-24T15:15:16-06:00",
  "ApiVersion": "2010-04-01",
  "SubresourceUris": {
    "media": "/2010-04-01/Accounts/ACc69c1a91e3414f30edc24ab30973b1a9/Messages/SM50e04235c896af83798671664cba05d8/Media.json"
  }
}')
INSERT [dbo].[tblMessagesSend] ([MessageSendID], [MessageID], [DateSent], [ConfirmatedCode], [ResponseJSON]) VALUES (9, 23, CAST(N'2022-09-24T15:28:52.000' AS DateTime), N'ACc69c1a91e3414f30edc24ab30973b1a9', N'{
  "Body": "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry\u0027s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic",
  "NumSegments": "0",
  "Direction": {},
  "From": {},
  "To": "\u002B50377425139",
  "DateUpdated": "2022-09-24T15:28:52-06:00",
  "Uri": "/2010-04-01/Accounts/ACc69c1a91e3414f30edc24ab30973b1a9/Messages/SM554caa3045f013ef008aa01c4b12f7fc.json",
  "AccountSid": "ACc69c1a91e3414f30edc24ab30973b1a9",
  "NumMedia": "0",
  "Status": {},
  "MessagingServiceSid": "MG4c3641885324df1a1f1a2d47f3b6442d",
  "Sid": "SM554caa3045f013ef008aa01c4b12f7fc",
  "DateCreated": "2022-09-24T15:28:52-06:00",
  "ApiVersion": "2010-04-01",
  "SubresourceUris": {
    "media": "/2010-04-01/Accounts/ACc69c1a91e3414f30edc24ab30973b1a9/Messages/SM554caa3045f013ef008aa01c4b12f7fc/Media.json"
  }
}')
SET IDENTITY_INSERT [dbo].[tblMessagesSend] OFF
GO
ALTER TABLE [dbo].[tblMessagesSend]  WITH CHECK ADD  CONSTRAINT [FK_tblMessageSend_tblMessages] FOREIGN KEY([MessageID])
REFERENCES [dbo].[tblMessages] ([MessageID])
GO
ALTER TABLE [dbo].[tblMessagesSend] CHECK CONSTRAINT [FK_tblMessageSend_tblMessages]
GO
