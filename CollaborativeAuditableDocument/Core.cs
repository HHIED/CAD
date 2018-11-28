﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollaborativeAuditableDocument {
    public sealed class Core {
        public string User {get; set; }
        private static Core instance = null;
        public Form1 main { get; set; }

        private Core() {
        }

        public static Core Instance {
            get {
                if (instance == null) {
                    instance = new Core();
                }
                return instance;
            }
        }

        public bool Login(string user) {
            return true;
        }
    }
}