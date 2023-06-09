USE [JiangDemo]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 2023/6/9 10:24:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EnterpriseInfo]    Script Date: 2023/6/9 10:24:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EnterpriseInfo](
	[EnterpriseInfoID] [uniqueidentifier] NOT NULL,
	[CompanyName] [nvarchar](50) NULL,
	[CompanyCode] [varchar](20) NULL,
	[Province] [nvarchar](50) NULL,
	[City] [nvarchar](50) NULL,
	[Prefecture] [nvarchar](50) NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK_EnterpriseInfo] PRIMARY KEY CLUSTERED 
(
	[EnterpriseInfoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 2023/6/9 10:24:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [uniqueidentifier] NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[UserPwd] [nvarchar](50) NOT NULL,
	[Role] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[EnterpriseInfo] ([EnterpriseInfoID], [CompanyName], [CompanyCode], [Province], [City], [Prefecture], [Status]) VALUES (N'736946e5-cda8-8915-e863-0fa0361e69d2', N'本格电子有限责任公司', N'6228437307510989', N'安徽省', N'六安', N'金安区', 0)
INSERT [dbo].[EnterpriseInfo] ([EnterpriseInfoID], [CompanyName], [CompanyCode], [Province], [City], [Prefecture], [Status]) VALUES (N'3fa85f64-5717-4562-b3fc-2c963f66afa6', N'string', N'string', N'string', N'string', N'string', 0)
INSERT [dbo].[EnterpriseInfo] ([EnterpriseInfoID], [CompanyName], [CompanyCode], [Province], [City], [Prefecture], [Status]) VALUES (N'457a4a27-1d5b-4aba-b4e8-50220e009350', N'雷有限责任公司', N'6271996442840086', N'浙江省', N'杭州', N'萧山区', 0)
INSERT [dbo].[EnterpriseInfo] ([EnterpriseInfoID], [CompanyName], [CompanyCode], [Province], [City], [Prefecture], [Status]) VALUES (N'5e56c5b7-d091-f720-05ec-52979e1282cc', N'致远电子有限责任公司', N'6216392453899856', N'安徽省', N'六安', N'金安区', 0)
INSERT [dbo].[EnterpriseInfo] ([EnterpriseInfoID], [CompanyName], [CompanyCode], [Province], [City], [Prefecture], [Status]) VALUES (N'9f8c30b5-5bc9-50d6-fdfd-62ce99712538', N'璐有限责任公司', N'6226213079070458', N'安徽省', N'六安', N'金安区', 0)
INSERT [dbo].[EnterpriseInfo] ([EnterpriseInfoID], [CompanyName], [CompanyCode], [Province], [City], [Prefecture], [Status]) VALUES (N'371f9039-94df-797d-4773-6c99229da6d6', N'詩涵通讯有限责任公司', N'6237359574411668', N'安徽省', N'六安', N'金寨', 0)
INSERT [dbo].[EnterpriseInfo] ([EnterpriseInfoID], [CompanyName], [CompanyCode], [Province], [City], [Prefecture], [Status]) VALUES (N'4114a8a1-1106-3378-644d-6ccbbfc15d4f', N'唐电讯有限责任公司', N'6248303868378842', N'江苏省', N'苏州', N'吴中区', 0)
INSERT [dbo].[EnterpriseInfo] ([EnterpriseInfoID], [CompanyName], [CompanyCode], [Province], [City], [Prefecture], [Status]) VALUES (N'42ed422d-51cf-0cd5-613d-8f5f14377f9d', N'刘有限责任公司', N'6260931994711107', N'江苏省', N'苏州', N'虎丘区', 0)
INSERT [dbo].[EnterpriseInfo] ([EnterpriseInfoID], [CompanyName], [CompanyCode], [Province], [City], [Prefecture], [Status]) VALUES (N'44177651-8afe-5348-c4b9-90eae224accd', N'宋通讯有限责任公司', N'6276216368863748', N'江苏省', N'苏州', N'吴江', 0)
INSERT [dbo].[EnterpriseInfo] ([EnterpriseInfoID], [CompanyName], [CompanyCode], [Province], [City], [Prefecture], [Status]) VALUES (N'74f9bbdd-ff35-5cb4-7d4b-da93b129eb16', N'许記玩具有限责任公司', N'6258840313456704', N'浙江省', N'金华', N'金东区', 0)
INSERT [dbo].[EnterpriseInfo] ([EnterpriseInfoID], [CompanyName], [CompanyCode], [Province], [City], [Prefecture], [Status]) VALUES (N'ddd5b221-9f1d-7543-57fe-e8fba1514b80', N'子韬有限责任公司', N'6226531530298578', N'浙江省', N'金华', N'金东区', 0)
INSERT [dbo].[EnterpriseInfo] ([EnterpriseInfoID], [CompanyName], [CompanyCode], [Province], [City], [Prefecture], [Status]) VALUES (N'57b75afe-5e1c-3344-70b3-e9531ddbc0ba', N'雷有限责任公司', N'6271996442840086', N'浙江省', N'杭州', N'萧山区', 0)
GO
INSERT [dbo].[Users] ([UserId], [UserName], [UserPwd], [Role]) VALUES (N'5444c627-f4fb-4b87-ab50-bfa15ab01f1c', N'Admin', N'123', N'Admin')
INSERT [dbo].[Users] ([UserId], [UserName], [UserPwd], [Role]) VALUES (N'976b4a2c-d74d-410d-8926-dcf801ee5070', N'System', N'123', N'System')
GO
ALTER TABLE [dbo].[EnterpriseInfo] ADD  CONSTRAINT [DF_EnterpriseInfo_EnterpriseInfoID]  DEFAULT (newid()) FOR [EnterpriseInfoID]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_UserId]  DEFAULT (newid()) FOR [UserId]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'EnterpriseInfo', @level2type=N'COLUMN',@level2name=N'EnterpriseInfoID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'公司名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'EnterpriseInfo', @level2type=N'COLUMN',@level2name=N'CompanyName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'统一信用代码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'EnterpriseInfo', @level2type=N'COLUMN',@level2name=N'CompanyCode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'省份' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'EnterpriseInfo', @level2type=N'COLUMN',@level2name=N'Province'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'城市' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'EnterpriseInfo', @level2type=N'COLUMN',@level2name=N'City'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'区县' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'EnterpriseInfo', @level2type=N'COLUMN',@level2name=N'Prefecture'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'状态' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'EnterpriseInfo', @level2type=N'COLUMN',@level2name=N'Status'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'UserId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'账号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'UserName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'密码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'UserPwd'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'Role'
GO
