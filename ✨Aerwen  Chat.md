

# ✨Aerwen / Chat

#### 基于.NET6 + vue3.x前后端分离的实时聊天室



##  🍭概述

- 本项目适合有一定NetCore和 vue基础的开发人员

- 基于NET6实现的实时聊天室。整合最新技术高效快速开发，前后端分离模式，vue3Js 进行对接。

- > 现有功能：
  >
  > 1、登录
  >
  > 2、搜索&添加 好友/群聊
  >
  > 3、好友/群聊 实时图文聊天
  >
  > 4、emjoi表情
  >
  > 5、配套后台管理系统

```
如果需要帮助，可以加微信：a2679599887(收到会及时回复~)
或者在底下留言~
```

## 🍿在线体验

- 在线聊天室 体验：[http://chat.aerwen.net](http://chat.aerwen.net)
- 体验号 账号密码：test/test  |  test2/test2
- 在线后台管理 体验：[http://chatvue.aerwen.net](http://chatvue.aerwen.net)
- 账号密码：admin/123456



## 🌺特别鸣谢

[后端框架：ZrAdminNet (在此框架二次开发)](https://gitee.com/izory/ZrAdminNetCore?_from=gitee_search)

[前端参考: b站@**山羊の前端小窝**](https://space.bilibili.com/266664645/video)



## 🍕内置功能

1. 登录/注册

   ![](http://chat.aerwen.net/dev-api//demo/20221006/0D2F813792477BD3.jpg)

   注册流程：

   ![注册流程](http://chat.aerwen.net/dev-api//demo/20221006/E1F0C02868B80C90.gif)

2. 个人中心：修改个人信息。

   ![](http://chat.aerwen.net/dev-api//demo/20221006/571DD0F61CDA4A1F.jpg)

3. 添加好友/群聊：通过用户名或群名查找。

   ![](http://chat.aerwen.net/dev-api//demo/20221006/07E1DAB722B6AF59.jpg)

   好友申请：

   ![](http://chat.aerwen.net/dev-api//demo/20221006/43D09F04486C3611.jpg)

4. 好友简介：查看好友信息,可以修改好友备注。

   ![](http://chat.aerwen.net/dev-api//demo/20221006/0331C0145A6142ED.jpg)

5. 聊天：与好友实时聊天或者留言。

   ![](http://chat.aerwen.net/dev-api//demo/20221006/47FA28F82C08E7A7.jpg)

   ![](http://chat.aerwen.net/dev-api//demo/20221006/1126A7957679CDDB.gif)

   上传图片：

   ![](http://chat.aerwen.net/dev-api//uploads/20221006/9993196E456C7AEE.gif)

   群聊：

   ![](http://chat.aerwen.net/dev-api//demo/20221006/928D9CF4B92CEDB5.gif)

6. emjoi表情包：支持发送emjoi表情。

   [组件github地址](https://github.com/ADKcodeXD/Vue3-Emoji)

   ![](http://chat.aerwen.net/dev-api//demo/20221006/A7A24DAC5D504955.gif)

7. 配套后台管理 (附源码)

   ![](http://chat.aerwen.net/dev-api//demo/20221006/46AC0DC4C3DFE9FD.jpg)

![](http://chat.aerwen.net/dev-api//demo/20221006/C9E4F43B3CA85215.jpg)



## 🍞项目结构

```
├─ARW-net	->[.Net 后端]
├─ARW-vue-main	->[后台管理vue]
├─chat_room_vue	->[聊天室前端vue]
```



## 🔧使用介绍

后端启动：打开 **ARWAdmin.sln** 后 ctrl+F5

详细文档： [ZRAdmin.NET在线文档 (izhaorui.cn)](http://www.izhaorui.cn/doc/)



前端启动： 

```
进入项目目录：chat_room_vue

# 安装依赖
npm install --registry=https://registry.npm.taobao.org

# 本地开发 启动项目
npm run dev
```



详细技术要点：

