﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApp.Models {
    public class User {
        private int userID;
        public int UserID {
            get { return this.userID; }
            set {
                if (value >= 0) {
                    this.userID = value;
                }
            }
        }

        public string Username { get; set; }
        public string Password { get; set; }
    }
}