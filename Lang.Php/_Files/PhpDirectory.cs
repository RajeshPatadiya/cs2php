﻿using Lang.Php.Runtime;
using System;

// ReSharper disable once CheckNamespace
namespace Lang.Php
{

    [Skip]
    public class PhpDirectory
    {
        [UseBinaryExpression("!==", "this", "false")]
        public virtual bool IsOk
        {
            get
            {
                throw new NotSupportedException();
                // return _ok;
            }
        }

        protected PhpDirectory()
        {

        }
        [DirectCall("mkdir")]
        public static PhpDirectory Make(string dirName)
        {           
            return new RuntimePhpDirectory(dirName);
        }

        [DirectCall("mkdir")]
        public static PhpDirectory Make(string dirName, UnixFilePermissions perm)
        {
            return new RuntimePhpDirectory(dirName);
        }

        [DirectCall("readdir", "0,this", 0)]
        public virtual bool ReadDir(out PhpDirectoryEntry file)
        {
            throw new MockMethodException();
            // readdir
        }

        [DirectCall("closedir", "this")]
        public void Close()
        {

        }

        [DirectCall("opendir", "0")]
        public static PhpDirectory Open(string dirName)
        {
            throw new NotImplementedException();
        }
    }

}
