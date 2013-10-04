﻿/*
 * @version   : 2.3.0
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2013-10-04
 * @copyright : Copyright (c) 2008-2013, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 * @website   : http://www.ext.net/
 */

using System.Text.RegularExpressions;

namespace Ext.Net.Utilities
{
    /// <summary>
    /// 
    /// </summary>
    public static class HtmlUtils
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="html"></param>
        /// <returns></returns>
        public static string StripWhitespaceChars(this string html)
        {
            return Regex.Replace(html, "[\n\r\t]", "");
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="html"></param>
        /// <returns></returns>
        public static string StripExtraSpaces(this string html)
        {
            return Regex.Replace(html, @"\s+", " ");
        }
    }
}