﻿/*
Copyright (C) 2016 Anki Universal Team <ankiuniversal@outlook.com>

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU Affero General Public License as
published by the Free Software Foundation, either version 3 of the
License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU Affero General Public License for more details.

You should have received a copy of the GNU Affero General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace AnkiU.Anki
{
    public static class HtmlHelpter
    {
        public static void LoadLocalHtml(WebView webView, string path)
        {
            CardStreamUriWinRTResolver resolver = new CardStreamUriWinRTResolver();
            var localUri = webView.BuildLocalStreamUri("HtmlViewer", path);
            webView.NavigateToLocalStreamUri(localUri, resolver);
        }
    }
}