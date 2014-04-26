﻿//============================================================================
// BDInfo - Blu-ray Video and Audio Analysis Tool
// Copyright © 2010 Cinema Squid
//
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
//
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
//=============================================================================

using BDInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
namespace BDInfoLib
{
    static class Program
    {
       

        static void Main()
        {
            String path = "Z:\\htpc13\\WORKING\\hot_tub_time_machine\\BDMV";
            runner run = new runner();
            run.InitBDROM(path);
            TSPlaylistFile selectedPlayList = run.SelectPlayList();
            List<TSPlaylistFile> list = new List<TSPlaylistFile>() { selectedPlayList };
            run.AddStreamFilesInPlaylists(list);

            System.Console.Read();
        }

    }
}

