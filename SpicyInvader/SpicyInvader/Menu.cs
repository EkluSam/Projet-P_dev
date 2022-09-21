﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpicyInvader
{
    internal class Menu
    {
        public Menu()
        {

        }

        private const string PLAY = @"
                               _  ____  _    _ ______ _____  
                              | |/ __ \| |  | |  ____|  __ \ 
                              | | |  | | |  | | |__  | |__) |
                          _   | | |  | | |  | |  __| |  _  / 
                         | |__| | |__| | |__| | |____| | \ \ 
                          \____/ \____/ \____/|______|_|  \_\               
        ";

        private const string OPTION = @"
                           ____  _____ _______ _____ ____  _   _ 
                          / __ \|  __ \__   __|_   _/ __ \| \ | |
                         | |  | | |__) | | |    | || |  | |  \| |
                         | |  | |  ___/  | |    | || |  | | . ` |
                         | |__| | |      | |   _| || |__| | |\  |
                          \____/|_|      |_|  |_____\____/|_| \_|
        ";

        private const string SCORE = @"
                 _    _ _____ _____ _    _  _____  _____ ____  _____  ______  _____ 
                | |  | |_   _/ ____| |  | |/ ____|/ ____/ __ \|  __ \|  ____|/ ____|
                | |__| | | || |  __| |__| | (___ | |   | |  | | |__) | |__  | (___  
                |  __  | | || | |_ |  __  |\___ \| |   | |  | |  _  /|  __|  \___ \ 
                | |  | |_| || |__| | |  | |____) | |___| |__| | | \ \| |____ ____) |
                |_|  |_|_____\_____|_|  |_|_____/ \_____\____/|_|  \_\______|_____/    
        ";

        private const string ABOUT = @"
                                   _____  _____   ____  _____   ____   _____
                        /\        |  __ \|  __ \ / __ \|  __ \ / __ \ / ____|
                       /  \       | |__) | |__) | |  | | |__) | |  | | (___  
                      / /\ \      |  ___/|  _  /| |  | |  ___/| |  | |\___ \ 
                     / ____ \     | |    | | \ \| |__| | |    | |__| |____) |
                    /_/    \_\    |_|    |_|  \_\\____/|_|     \____/|_____/ 
        ";

        private const string QUIT = @"
                           ____  _    _ _____ _______ _______ ______ _____  
                          / __ \| |  | |_   _|__   __|__   __|  ____|  __ \ 
                         | |  | | |  | | | |    | |     | |  | |__  | |__) |
                         | |  | | |  | | | |    | |     | |  |  __| |  _  / 
                         | |__| | |__| |_| |_   | |     | |  | |____| | \ \ 
                          \___\_\\____/|_____|  |_|     |_|  |______|_|  \_\
        ";

    }
}
