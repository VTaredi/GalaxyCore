﻿using System;
using System.Collections.Generic;
using System.Text;
using GalaxyCoreServer;
using GalaxyCoreCommon;
using GalaxyCoreServer.Api;
using GalaxyTemplate.Connecting;
using GalaxyTemplate.Instances;
using GalaxyTemplate.Clients;
using InstanceManager = GalaxyTemplate.Instances.InstanceManager;

namespace GalaxyTemplate
{
    public class Server
    {
        /// <summary>
        /// Пример реализации авторизации
        /// </summary>
        Authorization authorization = new Authorization();
        /// <summary>
        /// Конфигурация сервера
        /// </summary>
        Config config = new Config();
        /// <summary>
        /// Класс получающий входящие сообщения
        /// </summary>
        InMessages inMessages = new InMessages();
        /// <summary>
        /// Менеджер инстансов
        /// </summary>
        internal static InstanceManager instanceManager = new InstanceManager();
        /// <summary>
        /// Показывать ли дебаг сообщения
        /// </summary>
        internal static bool debugLog = true;

        internal static ClientManager clientManager = new ClientManager();


        public Server()
        {
            config.incomingMessage = inMessages; // Регистрируем обработчик входящих сообщений
            //Задаем имя сервера
            //Важно что бы имя сервера совпадало с именем указанным в клиенте
            config.SERVER_NAME = "ClassicTemplate";
            config.LISTEN_PORT = 30200; // Указываем рабочий порт
            GalaxyCore.Start(config); // Запускаем сервер
        }

    }
}
