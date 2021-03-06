using System;
using System.Collections.Generic;
using System.Text;

namespace BCW.Graph
{
    #region 类GifFrame
    /// <summary>
    /// Gif文件中可以包含多个图像，每个图像加上图像的一些特征，就组成了帧:GifFrame
    /// </summary>
    internal class GifFrame
    {
        #region private fields
        private ImageDescriptor _imgDes;
        private System.Drawing.Bitmap _img;
        private int _colorSize = 3;
        private byte[] _lct;
        private GraphicEx _graphicEx;
        private byte[] _buffer;        
        #endregion

        #region internal property
        /// <summary>
        /// 该桢的背景色
        /// </summary>
        public Color32 BgColor
        {
            get
            {
                Color32[] act = PaletteHelper.GetColor32s(LocalColorTable);
                return act[GraphicExtension.TranIndex];
            }            
        }
        /// <summary>
        /// 图象标识符(Image Descriptor)
        /// 一个GIF文件内可以包含多幅图象
        /// 一幅图象结束之后紧接着下是一幅图象的标识符，
        /// 图象标识符以0x2C(',')字符开始，
        /// 定义紧接着它的图象的性质，包括图象相对于逻辑屏幕边界的偏移量、
        /// 图象大小以及有无局部颜色列表和颜色列表大小
        /// </summary>
        internal ImageDescriptor ImageDescriptor
        {
            get { return _imgDes; }
            set { _imgDes = value; }
        }
               
        /// <summary>
        /// Gif的调色板
        /// </summary>
        internal Color32[] Palette
        {
            get
            {
                Color32[] act = PaletteHelper.GetColor32s(LocalColorTable);
                if (GraphicExtension != null && GraphicExtension.TransparencyFlag)
                {
                    act[GraphicExtension.TranIndex] = new Color32(0);
                }
                return act;
            }
        }

        /// <summary>
        /// 图像
        /// </summary>
        internal System.Drawing.Bitmap Image
        {
            get { return _img; }
            set { _img = value; }
        }
        
        /// <summary>
        /// 数据位大小
        /// </summary>
        internal int ColorDepth
        {
            get
            {
                return _colorSize;
            }
            set
            {
                _colorSize = value;
            }
        }
        
        /// <summary>
        /// 局部颜色列表(Local Color Table)
        /// 如果上面的局部颜色列表标志置位的话，则需要在这里（紧跟在图象标识符之后）
        /// 定义一个局部颜色列表以供紧接着它的图象使用，注意使用前应线保存原来的颜色列表，
        /// 使用结束之后回复原来保存的全局颜色列表。如果一个GIF文件即没有提供全局颜色列表
        /// 也没有提供局部颜色列表，可以自己创建一个颜色列表，或使用系统的颜色列表。
        /// RGBRGB......
        /// </summary>
        internal byte[] LocalColorTable
        {
            get { return _lct; }
            set { _lct = value; }
        }
        
        /// <summary>
        /// 图形控制扩展(Graphic Control Extension)这一部分是可选的（需要89a版本），
        /// 可以放在一个图象块(包括图象标识符、局部颜色列表和图象数据)或文本扩展块的前面，
        /// 用来控制跟在它后面的第一个图象（或文本）的渲染(Render)形式
        /// </summary>
        internal GraphicEx GraphicExtension
        {
            get { return _graphicEx; }
            set { _graphicEx = value; }
        }

        /// <summary>
        /// 延迟-与下一帧之间的时间间隔
        /// </summary>
        internal short Delay
        {
            get { return _graphicEx.Delay; }
            set { _graphicEx.Delay = value; }
        }
       
        /// <summary>
        /// 这个是经过LZW压缩算法后的数据流
        /// </summary>
        internal byte[] IndexedPixel
        {
            get { return _buffer; }
            set { _buffer = value; }
        }
        #endregion
    }
    #endregion
}
