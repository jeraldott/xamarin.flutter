﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using FlutterBinding.Engine.Painting;
using FlutterBinding.Mapping;
using FlutterBinding.UI;
using FlutterSDK;
using FlutterSDK.Animation.Animation;
using FlutterSDK.Animation.Animationcontroller;
using FlutterSDK.Animation.Animations;
using FlutterSDK.Animation.Curves;
using FlutterSDK.Animation.Listenerhelpers;
using FlutterSDK.Animation.Tween;
using FlutterSDK.Animation.Tweensequence;
using FlutterSDK.Foundation;
using FlutterSDK.Foundation._Bitfieldio;
using FlutterSDK.Foundation._Isolatesio;
using FlutterSDK.Foundation._Platformio;
using FlutterSDK.Foundation.Annotations;
using FlutterSDK.Foundation.Assertions;
using FlutterSDK.Foundation.Basictypes;
using FlutterSDK.Foundation.Binding;
using FlutterSDK.Foundation.Bitfield;
using FlutterSDK.Foundation.Changenotifier;
using FlutterSDK.Foundation.Collections;
using FlutterSDK.Foundation.Consolidateresponse;
using FlutterSDK.Foundation.Constants;
using FlutterSDK.Foundation.Debug;
using FlutterSDK.Foundation.Diagnostics;
using FlutterSDK.Foundation.Isolates;
using FlutterSDK.Foundation.Key;
using FlutterSDK.Foundation.Licenses;
using FlutterSDK.Foundation.Node;
using FlutterSDK.Foundation.@object;
using FlutterSDK.Foundation.Observerlist;
using FlutterSDK.Foundation.Platform;
using FlutterSDK.Foundation.Print;
using FlutterSDK.Foundation.Profile;
using FlutterSDK.Foundation.Serialization;
using FlutterSDK.Foundation.Stackframe;
using FlutterSDK.Foundation.Synchronousfuture;
using FlutterSDK.Foundation.Unicode;
using FlutterSDK.Gestures.Arena;
using FlutterSDK.Gestures.Binding;
using FlutterSDK.Gestures.Constants;
using FlutterSDK.Gestures.Converter;
using FlutterSDK.Gestures.Debug;
using FlutterSDK.Gestures.Drag;
using FlutterSDK.Gestures.Dragdetails;
using FlutterSDK.Gestures.Eager;
using FlutterSDK.Gestures.Events;
using FlutterSDK.Gestures.Forcepress;
using FlutterSDK.Gestures.Hittest;
using FlutterSDK.Gestures.Longpress;
using FlutterSDK.Gestures.Lsqsolver;
using FlutterSDK.Gestures.Monodrag;
using FlutterSDK.Gestures.Multidrag;
using FlutterSDK.Gestures.Multitap;
using FlutterSDK.Gestures.Pointerrouter;
using FlutterSDK.Gestures.Pointersignalresolver;
using FlutterSDK.Gestures.Recognizer;
using FlutterSDK.Gestures.Scale;
using FlutterSDK.Gestures.Tap;
using FlutterSDK.Gestures.Team;
using FlutterSDK.Gestures.Velocitytracker;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Appbar;
using FlutterSDK.Material.Appbartheme;
using FlutterSDK.Material.Arc;
using FlutterSDK.Material.Backbutton;
using FlutterSDK.Material.Bannertheme;
using FlutterSDK.Material.Bottomappbartheme;
using FlutterSDK.Material.Bottomsheet;
using FlutterSDK.Material.Bottomsheettheme;
using FlutterSDK.Material.Button;
using FlutterSDK.Material.Buttonbar;
using FlutterSDK.Material.Buttonbartheme;
using FlutterSDK.Material.Buttontheme;
using FlutterSDK.Material.Card;
using FlutterSDK.Material.Cardtheme;
using FlutterSDK.Material.Checkbox;
using FlutterSDK.Material.Chiptheme;
using FlutterSDK.Material.Colors;
using FlutterSDK.Material.Colorscheme;
using FlutterSDK.Material.Constants;
using FlutterSDK.Material.Curves;
using FlutterSDK.Material.Datatable;
using FlutterSDK.Material.Datatablesource;
using FlutterSDK.Material.Debug;
using FlutterSDK.Material.Dialog;
using FlutterSDK.Material.Dialogtheme;
using FlutterSDK.Material.Divider;
using FlutterSDK.Material.Dividertheme;
using FlutterSDK.Material.Drawer;
using FlutterSDK.Material.Drawerheader;
using FlutterSDK.Material.Dropdown;
using FlutterSDK.Material.Elevationoverlay;
using FlutterSDK.Material.Expandicon;
using FlutterSDK.Material.Feedback;
using FlutterSDK.Material.Flatbutton;
using FlutterSDK.Material.Flexiblespacebar;
using FlutterSDK.Material.Floatingactionbutton;
using FlutterSDK.Material.Floatingactionbuttonlocation;
using FlutterSDK.Material.Floatingactionbuttontheme;
using FlutterSDK.Material.Iconbutton;
using FlutterSDK.Material.Icons;
using FlutterSDK.Material.Inkdecoration;
using FlutterSDK.Material.Inkhighlight;
using FlutterSDK.Material.Inksplash;
using FlutterSDK.Material.Inkwell;
using FlutterSDK.Material.Inputborder;
using FlutterSDK.Material.Inputdecorator;
using FlutterSDK.Material.Listtile;
using FlutterSDK.Material.Material;
using FlutterSDK.Material.Materialbutton;
using FlutterSDK.Material.Materiallocalizations;
using FlutterSDK.Material.Materialstate;
using FlutterSDK.Material.Mergeablematerial;
using FlutterSDK.Material.Navigationrail;
using FlutterSDK.Material.Navigationrailtheme;
using FlutterSDK.Material.Outlinebutton;
using FlutterSDK.Material.Page;
using FlutterSDK.Material.Pagetransitionstheme;
using FlutterSDK.Material.Pickers.Calendardatepicker;
using FlutterSDK.Material.Pickers.Datepickercommon;
using FlutterSDK.Material.Pickers.Datepickerheader;
using FlutterSDK.Material.Pickers.Dateutils;
using FlutterSDK.Material.Pickers.Inputdatepicker;
using FlutterSDK.Material.Popupmenutheme;
using FlutterSDK.Material.Progressindicator;
using FlutterSDK.Material.Radio;
using FlutterSDK.Material.Raisedbutton;
using FlutterSDK.Material.Reorderablelist;
using FlutterSDK.Material.Scaffold;
using FlutterSDK.Material.Scrollbar;
using FlutterSDK.Material.Selectabletext;
using FlutterSDK.Material.Shadows;
using FlutterSDK.Material.Slidertheme;
using FlutterSDK.Material.Snackbar;
using FlutterSDK.Material.Snackbartheme;
using FlutterSDK.Material.Switch;
using FlutterSDK.Material.Tabbartheme;
using FlutterSDK.Material.Tabcontroller;
using FlutterSDK.Material.Tabindicator;
using FlutterSDK.Material.Tabs;
using FlutterSDK.Material.Textfield;
using FlutterSDK.Material.Textformfield;
using FlutterSDK.Material.Textselection;
using FlutterSDK.Material.Texttheme;
using FlutterSDK.Material.Theme;
using FlutterSDK.Material.Themedata;
using FlutterSDK.Material.Time;
using FlutterSDK.Material.Toggleable;
using FlutterSDK.Material.Togglebuttonstheme;
using FlutterSDK.Material.Tooltip;
using FlutterSDK.Material.Tooltiptheme;
using FlutterSDK.Material.Typography;
using FlutterSDK.Painting._Networkimageio;
using FlutterSDK.Painting.Alignment;
using FlutterSDK.Painting.Basictypes;
using FlutterSDK.Painting.Beveledrectangleborder;
using FlutterSDK.Painting.Binding;
using FlutterSDK.Painting.Borderradius;
using FlutterSDK.Painting.Borders;
using FlutterSDK.Painting.Boxborder;
using FlutterSDK.Painting.Boxdecoration;
using FlutterSDK.Painting.Boxfit;
using FlutterSDK.Painting.Boxshadow;
using FlutterSDK.Painting.Circleborder;
using FlutterSDK.Painting.Clip;
using FlutterSDK.Painting.Colors;
using FlutterSDK.Painting.Continuousrectangleborder;
using FlutterSDK.Painting.Debug;
using FlutterSDK.Painting.Decoration;
using FlutterSDK.Painting.Decorationimage;
using FlutterSDK.Painting.Edgeinsets;
using FlutterSDK.Painting.Flutterlogo;
using FlutterSDK.Painting.Fractionaloffset;
using FlutterSDK.Painting.Geometry;
using FlutterSDK.Painting.Gradient;
using FlutterSDK.Painting.Imagecache;
using FlutterSDK.Painting.Imagedecoder;
using FlutterSDK.Painting.Imageprovider;
using FlutterSDK.Painting.Imageresolution;
using FlutterSDK.Painting.Imagestream;
using FlutterSDK.Painting.Inlinespan;
using FlutterSDK.Painting.Matrixutils;
using FlutterSDK.Painting.Notchedshapes;
using FlutterSDK.Painting.Paintutilities;
using FlutterSDK.Painting.Placeholderspan;
using FlutterSDK.Painting.Roundedrectangleborder;
using FlutterSDK.Painting.Shaderwarmup;
using FlutterSDK.Painting.Shapedecoration;
using FlutterSDK.Painting.Stadiumborder;
using FlutterSDK.Painting.Strutstyle;
using FlutterSDK.Painting.Textpainter;
using FlutterSDK.Painting.Textspan;
using FlutterSDK.Painting.Textstyle;
using FlutterSDK.Physics.Clampedsimulation;
using FlutterSDK.Physics.Frictionsimulation;
using FlutterSDK.Physics.Gravitysimulation;
using FlutterSDK.Physics.Simulation;
using FlutterSDK.Physics.Springsimulation;
using FlutterSDK.Physics.Tolerance;
using FlutterSDK.Physics.Utils;
using FlutterSDK.Rendering.Animatedsize;
using FlutterSDK.Rendering.Binding;
using FlutterSDK.Rendering.Box;
using FlutterSDK.Rendering.Customlayout;
using FlutterSDK.Rendering.Custompaint;
using FlutterSDK.Rendering.Debug;
using FlutterSDK.Rendering.Debugoverflowindicator;
using FlutterSDK.Rendering.Editable;
using FlutterSDK.Rendering.Error;
using FlutterSDK.Rendering.Flex;
using FlutterSDK.Rendering.Flow;
using FlutterSDK.Rendering.Image;
using FlutterSDK.Rendering.Layer;
using FlutterSDK.Rendering.Listbody;
using FlutterSDK.Rendering.Listwheelviewport;
using FlutterSDK.Rendering.Mousetracking;
using FlutterSDK.Rendering.@object;
using FlutterSDK.Rendering.Paragraph;
using FlutterSDK.Rendering.Performanceoverlay;
using FlutterSDK.Rendering.Platformview;
using FlutterSDK.Rendering.Proxybox;
using FlutterSDK.Rendering.Proxysliver;
using FlutterSDK.Rendering.Rotatedbox;
using FlutterSDK.Rendering.Shiftedbox;
using FlutterSDK.Rendering.Sliver;
using FlutterSDK.Rendering.Sliverfill;
using FlutterSDK.Rendering.Sliverfixedextentlist;
using FlutterSDK.Rendering.Slivergrid;
using FlutterSDK.Rendering.Sliverlist;
using FlutterSDK.Rendering.Slivermultiboxadaptor;
using FlutterSDK.Rendering.Sliverpadding;
using FlutterSDK.Rendering.Sliverpersistentheader;
using FlutterSDK.Rendering.Stack;
using FlutterSDK.Rendering.Table;
using FlutterSDK.Rendering.Tableborder;
using FlutterSDK.Rendering.Texture;
using FlutterSDK.Rendering.Tweens;
using FlutterSDK.Rendering.View;
using FlutterSDK.Rendering.Viewport;
using FlutterSDK.Rendering.Viewportoffset;
using FlutterSDK.Rendering.Wrap;
using FlutterSDK.Scheduler;
using FlutterSDK.Scheduler.Binding;
using FlutterSDK.Scheduler.Debug;
using FlutterSDK.Scheduler.Priority;
using FlutterSDK.Scheduler.Ticker;
using FlutterSDK.Semantics.Binding;
using FlutterSDK.Semantics.Debug;
using FlutterSDK.Semantics.Semantics;
using FlutterSDK.Semantics.Semanticsevent;
using FlutterSDK.Semantics.Semanticsservice;
using FlutterSDK.Services.Assetbundle;
using FlutterSDK.Services.Binarymessenger;
using FlutterSDK.Services.Binding;
using FlutterSDK.Services.Clipboard;
using FlutterSDK.Services.Fontloader;
using FlutterSDK.Services.Hapticfeedback;
using FlutterSDK.Services.Keyboardkey;
using FlutterSDK.Services.Keyboardmaps;
using FlutterSDK.Services.Messagecodec;
using FlutterSDK.Services.Messagecodecs;
using FlutterSDK.Services.Platformchannel;
using FlutterSDK.Services.Platformmessages;
using FlutterSDK.Services.Platformviews;
using FlutterSDK.Services.Rawkeyboard;
using FlutterSDK.Services.Rawkeyboardandroid;
using FlutterSDK.Services.Rawkeyboardfuchsia;
using FlutterSDK.Services.Rawkeyboardlinux;
using FlutterSDK.Services.Rawkeyboardmacos;
using FlutterSDK.Services.Rawkeyboardweb;
using FlutterSDK.Services.Systemchannels;
using FlutterSDK.Services.Systemchrome;
using FlutterSDK.Services.Systemnavigator;
using FlutterSDK.Services.Systemsound;
using FlutterSDK.Services.Textediting;
using FlutterSDK.Services.Textformatter;
using FlutterSDK.Services.Textinput;
using FlutterSDK.Widgets.Actions;
using FlutterSDK.Widgets.Animatedcrossfade;
using FlutterSDK.Widgets.Animatedlist;
using FlutterSDK.Widgets.Animatedsize;
using FlutterSDK.Widgets.Animatedswitcher;
using FlutterSDK.Widgets.Annotatedregion;
using FlutterSDK.Widgets.App;
using FlutterSDK.Widgets.Async;
using FlutterSDK.Widgets.Automatickeepalive;
using FlutterSDK.Widgets.Banner;
using FlutterSDK.Widgets.Basic;
using FlutterSDK.Widgets.Binding;
using FlutterSDK.Widgets.Bottomnavigationbaritem;
using FlutterSDK.Widgets.Colorfilter;
using FlutterSDK.Widgets.Container;
using FlutterSDK.Widgets.Debug;
using FlutterSDK.Widgets.Dismissible;
using FlutterSDK.Widgets.Disposablebuildcontext;
using FlutterSDK.Widgets.Draggablescrollablesheet;
using FlutterSDK.Widgets.Dragtarget;
using FlutterSDK.Widgets.Editabletext;
using FlutterSDK.Widgets.Fadeinimage;
using FlutterSDK.Widgets.Focusmanager;
using FlutterSDK.Widgets.Focusscope;
using FlutterSDK.Widgets.Focustraversal;
using FlutterSDK.Widgets.Form;
using FlutterSDK.Widgets.Framework;
using FlutterSDK.Widgets.Gesturedetector;
using FlutterSDK.Widgets.Gridpaper;
using FlutterSDK.Widgets.Heroes;
using FlutterSDK.Widgets.Icon;
using FlutterSDK.Widgets.Icondata;
using FlutterSDK.Widgets.Icontheme;
using FlutterSDK.Widgets.Iconthemedata;
using FlutterSDK.Widgets.Image;
using FlutterSDK.Widgets.Imagefilter;
using FlutterSDK.Widgets.Imageicon;
using FlutterSDK.Widgets.Implicitanimations;
using FlutterSDK.Widgets.Inheritedmodel;
using FlutterSDK.Widgets.Inheritednotifier;
using FlutterSDK.Widgets.Inheritedtheme;
using FlutterSDK.Widgets.Layoutbuilder;
using FlutterSDK.Widgets.Listwheelscrollview;
using FlutterSDK.Widgets.Localizations;
using FlutterSDK.Widgets.Mediaquery;
using FlutterSDK.Widgets.Modalbarrier;
using FlutterSDK.Widgets.Navigationtoolbar;
using FlutterSDK.Widgets.Navigator;
using FlutterSDK.Widgets.Nestedscrollview;
using FlutterSDK.Widgets.Notificationlistener;
using FlutterSDK.Widgets.Orientationbuilder;
using FlutterSDK.Widgets.Overlay;
using FlutterSDK.Widgets.Overscrollindicator;
using FlutterSDK.Widgets.Pages;
using FlutterSDK.Widgets.Pagestorage;
using FlutterSDK.Widgets.Pageview;
using FlutterSDK.Widgets.Performanceoverlay;
using FlutterSDK.Widgets.Placeholder;
using FlutterSDK.Widgets.Platformview;
using FlutterSDK.Widgets.Preferredsize;
using FlutterSDK.Widgets.Primaryscrollcontroller;
using FlutterSDK.Widgets.Rawkeyboardlistener;
using FlutterSDK.Widgets.Routes;
using FlutterSDK.Widgets.Safearea;
using FlutterSDK.Widgets.Scrollable;
using FlutterSDK.Widgets.Scrollactivity;
using FlutterSDK.Widgets.Scrollawareimageprovider;
using FlutterSDK.Widgets.Scrollbar;
using FlutterSDK.Widgets.Scrollconfiguration;
using FlutterSDK.Widgets.Scrollcontext;
using FlutterSDK.Widgets.Scrollcontroller;
using FlutterSDK.Widgets.Scrollmetrics;
using FlutterSDK.Widgets.Scrollnotification;
using FlutterSDK.Widgets.Scrollphysics;
using FlutterSDK.Widgets.Scrollposition;
using FlutterSDK.Widgets.Scrollpositionwithsinglecontext;
using FlutterSDK.Widgets.Scrollsimulation;
using FlutterSDK.Widgets.Scrollview;
using FlutterSDK.Widgets.Semanticsdebugger;
using FlutterSDK.Widgets.Shortcuts;
using FlutterSDK.Widgets.Singlechildscrollview;
using FlutterSDK.Widgets.Sizechangedlayoutnotifier;
using FlutterSDK.Widgets.Sliver;
using FlutterSDK.Widgets.Sliverfill;
using FlutterSDK.Widgets.Sliverlayoutbuilder;
using FlutterSDK.Widgets.Sliverpersistentheader;
using FlutterSDK.Widgets.Sliverprototypeextentlist;
using FlutterSDK.Widgets.Spacer;
using FlutterSDK.Widgets.Statustransitions;
using FlutterSDK.Widgets.Table;
using FlutterSDK.Widgets.Text;
using FlutterSDK.Widgets.Textselection;
using FlutterSDK.Widgets.Texture;
using FlutterSDK.Widgets.Tickerprovider;
using FlutterSDK.Widgets.Title;
using FlutterSDK.Widgets.Transitions;
using FlutterSDK.Widgets.Tweenanimationbuilder;
using FlutterSDK.Widgets.Uniquewidget;
using FlutterSDK.Widgets.Valuelistenablebuilder;
using FlutterSDK.Widgets.Viewport;
using FlutterSDK.Widgets.Visibility;
using FlutterSDK.Widgets.Widgetinspector;
using FlutterSDK.Widgets.Widgetspan;
using FlutterSDK.Widgets.Willpopscope;
using SkiaSharp;
using static FlutterSDK.Global;
namespace FlutterSDK.Rendering.Slivergrid
{
    internal static class SlivergridDefaultClass
    {
    }

    /// <Summary>
    /// The size and position of all the tiles in a [RenderSliverGrid].
    ///
    /// Rather that providing a grid with a [SliverGridLayout] directly, you instead
    /// provide the grid a [SliverGridDelegate], which can compute a
    /// [SliverGridLayout] given the current [SliverConstraints].
    ///
    /// The tiles can be placed arbitrarily, but it is more efficient to place tiles
    /// in roughly in order by scroll offset because grids reify a contiguous
    /// sequence of children.
    ///
    /// See also:
    ///
    ///  * [SliverGridRegularTileLayout], which represents a layout that uses
    ///    equally sized and spaced tiles.
    ///  * [SliverGridGeometry], which represents the size and position of a single
    ///    tile in a grid.
    ///  * [SliverGridDelegate.getLayout], which returns this object to describe the
    ///    delegate's layout.
    ///  * [RenderSliverGrid], which uses this class during its
    ///    [RenderSliverGrid.performLayout] method.
    /// </Summary>
    public interface ISliverGridLayout
    {
        int GetMinChildIndexForScrollOffset(double scrollOffset);
        int GetMaxChildIndexForScrollOffset(double scrollOffset);
        FlutterSDK.Rendering.Slivergrid.SliverGridGeometry GetGeometryForChildIndex(int index);
        double ComputeMaxScrollOffset(int childCount);
    }


    /// <Summary>
    /// Controls the layout of tiles in a grid.
    ///
    /// Given the current constraints on the grid, a [SliverGridDelegate] computes
    /// the layout for the tiles in the grid. The tiles can be placed arbitrarily,
    /// but it is more efficient to place tiles in roughly in order by scroll offset
    /// because grids reify a contiguous sequence of children.
    ///
    /// See also:
    ///
    ///  * [SliverGridDelegateWithFixedCrossAxisCount], which creates a layout with
    ///    a fixed number of tiles in the cross axis.
    ///  * [SliverGridDelegateWithMaxCrossAxisExtent], which creates a layout with
    ///    tiles that have a maximum cross-axis extent.
    ///  * [GridView], which uses this delegate to control the layout of its tiles.
    ///  * [SliverGrid], which uses this delegate to control the layout of its
    ///    tiles.
    ///  * [RenderSliverGrid], which uses this delegate to control the layout of its
    ///    tiles.
    /// </Summary>
    public interface ISliverGridDelegate
    {
        FlutterSDK.Rendering.Slivergrid.SliverGridLayout GetLayout(FlutterSDK.Rendering.Sliver.SliverConstraints constraints);
        bool ShouldRelayout(FlutterSDK.Rendering.Slivergrid.SliverGridDelegate oldDelegate);
    }


    /// <Summary>
    /// Describes the placement of a child in a [RenderSliverGrid].
    ///
    /// See also:
    ///
    ///  * [SliverGridLayout], which represents the geometry of all the tiles in a
    ///    grid.
    ///  * [SliverGridLayout.getGeometryForChildIndex], which returns this object
    ///    to describe the child's placement.
    ///  * [RenderSliverGrid], which uses this class during its
    ///    [RenderSliverGrid.performLayout] method.
    /// </Summary>
    public class SliverGridGeometry
    {
        /// <Summary>
        /// Creates an object that describes the placement of a child in a [RenderSliverGrid].
        /// </Summary>
        public SliverGridGeometry(double scrollOffset = default(double), double crossAxisOffset = default(double), double mainAxisExtent = default(double), double crossAxisExtent = default(double))
        {
            this.ScrollOffset = scrollOffset;
            this.CrossAxisOffset = crossAxisOffset;
            this.MainAxisExtent = mainAxisExtent;
            this.CrossAxisExtent = crossAxisExtent;
        }
        /// <Summary>
        /// The scroll offset of the leading edge of the child relative to the leading
        /// edge of the parent.
        /// </Summary>
        public virtual double ScrollOffset { get; set; }
        /// <Summary>
        /// The offset of the child in the non-scrolling axis.
        ///
        /// If the scroll axis is vertical, this offset is from the left-most edge of
        /// the parent to the left-most edge of the child. If the scroll axis is
        /// horizontal, this offset is from the top-most edge of the parent to the
        /// top-most edge of the child.
        /// </Summary>
        public virtual double CrossAxisOffset { get; set; }
        /// <Summary>
        /// The extent of the child in the scrolling axis.
        ///
        /// If the scroll axis is vertical, this extent is the child's height. If the
        /// scroll axis is horizontal, this extent is the child's width.
        /// </Summary>
        public virtual double MainAxisExtent { get; set; }
        /// <Summary>
        /// The extent of the child in the non-scrolling axis.
        ///
        /// If the scroll axis is vertical, this extent is the child's width. If the
        /// scroll axis is horizontal, this extent is the child's height.
        /// </Summary>
        public virtual double CrossAxisExtent { get; set; }
        public virtual double TrailingScrollOffset { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Returns a tight [BoxConstraints] that forces the child to have the
        /// required size.
        /// </Summary>
        public virtual FlutterSDK.Rendering.Box.BoxConstraints GetBoxConstraints(FlutterSDK.Rendering.Sliver.SliverConstraints constraints)
        {
            return constraints.AsBoxConstraints(minExtent: MainAxisExtent, maxExtent: MainAxisExtent, crossAxisExtent: CrossAxisExtent);
        }




    }


    /// <Summary>
    /// The size and position of all the tiles in a [RenderSliverGrid].
    ///
    /// Rather that providing a grid with a [SliverGridLayout] directly, you instead
    /// provide the grid a [SliverGridDelegate], which can compute a
    /// [SliverGridLayout] given the current [SliverConstraints].
    ///
    /// The tiles can be placed arbitrarily, but it is more efficient to place tiles
    /// in roughly in order by scroll offset because grids reify a contiguous
    /// sequence of children.
    ///
    /// See also:
    ///
    ///  * [SliverGridRegularTileLayout], which represents a layout that uses
    ///    equally sized and spaced tiles.
    ///  * [SliverGridGeometry], which represents the size and position of a single
    ///    tile in a grid.
    ///  * [SliverGridDelegate.getLayout], which returns this object to describe the
    ///    delegate's layout.
    ///  * [RenderSliverGrid], which uses this class during its
    ///    [RenderSliverGrid.performLayout] method.
    /// </Summary>
    public class SliverGridLayout
    {
        /// <Summary>
        /// Abstract const constructor. This constructor enables subclasses to provide
        /// const constructors so that they can be used in const expressions.
        /// </Summary>
        public SliverGridLayout()
        {

        }

        /// <Summary>
        /// The minimum child index that is visible at (or after) this scroll offset.
        /// </Summary>
        public virtual int GetMinChildIndexForScrollOffset(double scrollOffset)
        {
            return default(int);
        }


        /// <Summary>
        /// The maximum child index that is visible at (or before) this scroll offset.
        /// </Summary>
        public virtual int GetMaxChildIndexForScrollOffset(double scrollOffset)
        {
            return default(int);
        }


        /// <Summary>
        /// The size and position of the child with the given index.
        /// </Summary>
        public virtual FlutterSDK.Rendering.Slivergrid.SliverGridGeometry GetGeometryForChildIndex(int index)
        {
            return default(SliverGridGeometry);
        }


        /// <Summary>
        /// The scroll extent needed to fully display all the tiles if there are
        /// `childCount` children in total.
        ///
        /// The child count will never be null.
        /// </Summary>
        public virtual double ComputeMaxScrollOffset(int childCount)
        {
            return default(double);
        }

    }


    /// <Summary>
    /// A [SliverGridLayout] that uses equally sized and spaced tiles.
    ///
    /// Rather that providing a grid with a [SliverGridLayout] directly, you instead
    /// provide the grid a [SliverGridDelegate], which can compute a
    /// [SliverGridLayout] given the current [SliverConstraints].
    ///
    /// This layout is used by [SliverGridDelegateWithFixedCrossAxisCount] and
    /// [SliverGridDelegateWithMaxCrossAxisExtent].
    ///
    /// See also:
    ///
    ///  * [SliverGridDelegateWithFixedCrossAxisCount], which uses this layout.
    ///  * [SliverGridDelegateWithMaxCrossAxisExtent], which uses this layout.
    ///  * [SliverGridLayout], which represents an arbitrary tile layout.
    ///  * [SliverGridGeometry], which represents the size and position of a single
    ///    tile in a grid.
    ///  * [SliverGridDelegate.getLayout], which returns this object to describe the
    ///    delegate's layout.
    ///  * [RenderSliverGrid], which uses this class during its
    ///    [RenderSliverGrid.performLayout] method.
    /// </Summary>
    public class SliverGridRegularTileLayout : FlutterSDK.Rendering.Slivergrid.SliverGridLayout
    {
        /// <Summary>
        /// Creates a layout that uses equally sized and spaced tiles.
        ///
        /// All of the arguments must not be null and must not be negative. The
        /// `crossAxisCount` argument must be greater than zero.
        /// </Summary>
        public SliverGridRegularTileLayout(int crossAxisCount = default(int), double mainAxisStride = default(double), double crossAxisStride = default(double), double childMainAxisExtent = default(double), double childCrossAxisExtent = default(double), bool reverseCrossAxis = default(bool))
        : base()
        {
            this.CrossAxisCount = crossAxisCount;
            this.MainAxisStride = mainAxisStride;
            this.CrossAxisStride = crossAxisStride;
            this.ChildMainAxisExtent = childMainAxisExtent;
            this.ChildCrossAxisExtent = childCrossAxisExtent;
            this.ReverseCrossAxis = reverseCrossAxis;
        }
        /// <Summary>
        /// The number of children in the cross axis.
        /// </Summary>
        public virtual int CrossAxisCount { get; set; }
        /// <Summary>
        /// The number of pixels from the leading edge of one tile to the leading edge
        /// of the next tile in the main axis.
        /// </Summary>
        public virtual double MainAxisStride { get; set; }
        /// <Summary>
        /// The number of pixels from the leading edge of one tile to the leading edge
        /// of the next tile in the cross axis.
        /// </Summary>
        public virtual double CrossAxisStride { get; set; }
        /// <Summary>
        /// The number of pixels from the leading edge of one tile to the trailing
        /// edge of the same tile in the main axis.
        /// </Summary>
        public virtual double ChildMainAxisExtent { get; set; }
        /// <Summary>
        /// The number of pixels from the leading edge of one tile to the trailing
        /// edge of the same tile in the cross axis.
        /// </Summary>
        public virtual double ChildCrossAxisExtent { get; set; }
        /// <Summary>
        /// Whether the children should be placed in the opposite order of increasing
        /// coordinates in the cross axis.
        ///
        /// For example, if the cross axis is horizontal, the children are placed from
        /// left to right when [reverseCrossAxis] is false and from right to left when
        /// [reverseCrossAxis] is true.
        ///
        /// Typically set to the return value of [axisDirectionIsReversed] applied to
        /// the [SliverConstraints.crossAxisDirection].
        /// </Summary>
        public virtual bool ReverseCrossAxis { get; set; }

        public new int GetMinChildIndexForScrollOffset(double scrollOffset)
        {
            return MainAxisStride > 0.0 ? CrossAxisCount * (scrollOffset~/ MainAxisStride):0;
        }




        public new int GetMaxChildIndexForScrollOffset(double scrollOffset)
        {
            if (MainAxisStride > 0.0)
            {
                int mainAxisCount = (scrollOffset / MainAxisStride).Ceil();
                return Dart.Math.MathDefaultClass.Max(0, CrossAxisCount * mainAxisCount - 1);
            }

            return 0;
        }




        private double _GetOffsetFromStartInCrossAxis(double crossAxisStart)
        {
            if (ReverseCrossAxis) return CrossAxisCount * CrossAxisStride - crossAxisStart - ChildCrossAxisExtent - (CrossAxisStride - ChildCrossAxisExtent);
            return crossAxisStart;
        }




        public new FlutterSDK.Rendering.Slivergrid.SliverGridGeometry GetGeometryForChildIndex(int index)
        {
            double crossAxisStart = (index % CrossAxisCount) * CrossAxisStride;
            return new SliverGridGeometry(scrollOffset: (index~/ CrossAxisCount) * MainAxisStride, crossAxisOffset: _GetOffsetFromStartInCrossAxis(crossAxisStart), mainAxisExtent: ChildMainAxisExtent, crossAxisExtent: ChildCrossAxisExtent);
        }




        public new double ComputeMaxScrollOffset(int childCount)
        {

            int mainAxisCount = ((childCount - 1)~/ CrossAxisCount)+1;
            double mainAxisSpacing = MainAxisStride - ChildMainAxisExtent;
            return MainAxisStride * mainAxisCount - mainAxisSpacing;
        }



    }


    /// <Summary>
    /// Controls the layout of tiles in a grid.
    ///
    /// Given the current constraints on the grid, a [SliverGridDelegate] computes
    /// the layout for the tiles in the grid. The tiles can be placed arbitrarily,
    /// but it is more efficient to place tiles in roughly in order by scroll offset
    /// because grids reify a contiguous sequence of children.
    ///
    /// See also:
    ///
    ///  * [SliverGridDelegateWithFixedCrossAxisCount], which creates a layout with
    ///    a fixed number of tiles in the cross axis.
    ///  * [SliverGridDelegateWithMaxCrossAxisExtent], which creates a layout with
    ///    tiles that have a maximum cross-axis extent.
    ///  * [GridView], which uses this delegate to control the layout of its tiles.
    ///  * [SliverGrid], which uses this delegate to control the layout of its
    ///    tiles.
    ///  * [RenderSliverGrid], which uses this delegate to control the layout of its
    ///    tiles.
    /// </Summary>
    public class SliverGridDelegate
    {
        /// <Summary>
        /// Abstract const constructor. This constructor enables subclasses to provide
        /// const constructors so that they can be used in const expressions.
        /// </Summary>
        public SliverGridDelegate()
        {

        }

        /// <Summary>
        /// Returns information about the size and position of the tiles in the grid.
        /// </Summary>
        public virtual FlutterSDK.Rendering.Slivergrid.SliverGridLayout GetLayout(FlutterSDK.Rendering.Sliver.SliverConstraints constraints)
        {
            return default(SliverGridLayout);
        }


        /// <Summary>
        /// Override this method to return true when the children need to be
        /// laid out.
        ///
        /// This should compare the fields of the current delegate and the given
        /// `oldDelegate` and return true if the fields are such that the layout would
        /// be different.
        /// </Summary>
        public virtual bool ShouldRelayout(FlutterSDK.Rendering.Slivergrid.SliverGridDelegate oldDelegate)
        {
            return default(bool);
        }

    }


    /// <Summary>
    /// Creates grid layouts with a fixed number of tiles in the cross axis.
    ///
    /// For example, if the grid is vertical, this delegate will create a layout
    /// with a fixed number of columns. If the grid is horizontal, this delegate
    /// will create a layout with a fixed number of rows.
    ///
    /// This delegate creates grids with equally sized and spaced tiles.
    ///
    /// See also:
    ///
    ///  * [SliverGridDelegateWithMaxCrossAxisExtent], which creates a layout with
    ///    tiles that have a maximum cross-axis extent.
    ///  * [SliverGridDelegate], which creates arbitrary layouts.
    ///  * [GridView], which can use this delegate to control the layout of its
    ///    tiles.
    ///  * [SliverGrid], which can use this delegate to control the layout of its
    ///    tiles.
    ///  * [RenderSliverGrid], which can use this delegate to control the layout of
    ///    its tiles.
    /// </Summary>
    public class SliverGridDelegateWithFixedCrossAxisCount : FlutterSDK.Rendering.Slivergrid.SliverGridDelegate
    {
        /// <Summary>
        /// Creates a delegate that makes grid layouts with a fixed number of tiles in
        /// the cross axis.
        ///
        /// All of the arguments must not be null. The `mainAxisSpacing` and
        /// `crossAxisSpacing` arguments must not be negative. The `crossAxisCount`
        /// and `childAspectRatio` arguments must be greater than zero.
        /// </Summary>
        public SliverGridDelegateWithFixedCrossAxisCount(int crossAxisCount = default(int), double mainAxisSpacing = 0.0, double crossAxisSpacing = 0.0, double childAspectRatio = 1.0)
        : base()
        {
            this.CrossAxisCount = crossAxisCount;
            this.MainAxisSpacing = mainAxisSpacing;
            this.CrossAxisSpacing = crossAxisSpacing;
            this.ChildAspectRatio = childAspectRatio;
        }
        /// <Summary>
        /// The number of children in the cross axis.
        /// </Summary>
        public virtual int CrossAxisCount { get; set; }
        /// <Summary>
        /// The number of logical pixels between each child along the main axis.
        /// </Summary>
        public virtual double MainAxisSpacing { get; set; }
        /// <Summary>
        /// The number of logical pixels between each child along the cross axis.
        /// </Summary>
        public virtual double CrossAxisSpacing { get; set; }
        /// <Summary>
        /// The ratio of the cross-axis to the main-axis extent of each child.
        /// </Summary>
        public virtual double ChildAspectRatio { get; set; }

        private bool _DebugAssertIsValid()
        {




            return true;
        }




        public new FlutterSDK.Rendering.Slivergrid.SliverGridLayout GetLayout(FlutterSDK.Rendering.Sliver.SliverConstraints constraints)
        {

            double usableCrossAxisExtent = constraints.CrossAxisExtent - CrossAxisSpacing * (CrossAxisCount - 1);
            double childCrossAxisExtent = usableCrossAxisExtent / CrossAxisCount;
            double childMainAxisExtent = childCrossAxisExtent / ChildAspectRatio;
            return new SliverGridRegularTileLayout(crossAxisCount: CrossAxisCount, mainAxisStride: childMainAxisExtent + MainAxisSpacing, crossAxisStride: childCrossAxisExtent + CrossAxisSpacing, childMainAxisExtent: childMainAxisExtent, childCrossAxisExtent: childCrossAxisExtent, reverseCrossAxis: BasictypesDefaultClass.AxisDirectionIsReversed(constraints.CrossAxisDirection));
        }




        public new bool ShouldRelayout(FlutterSDK.Rendering.Slivergrid.SliverGridDelegateWithFixedCrossAxisCount oldDelegate)
        {
            return oldDelegate.CrossAxisCount != CrossAxisCount || oldDelegate.MainAxisSpacing != MainAxisSpacing || oldDelegate.CrossAxisSpacing != CrossAxisSpacing || oldDelegate.ChildAspectRatio != ChildAspectRatio;
        }


        public new bool ShouldRelayout(FlutterSDK.Rendering.Slivergrid.SliverGridDelegate oldDelegate)
        {
            return oldDelegate.CrossAxisCount != CrossAxisCount || oldDelegate.MainAxisSpacing != MainAxisSpacing || oldDelegate.CrossAxisSpacing != CrossAxisSpacing || oldDelegate.ChildAspectRatio != ChildAspectRatio;
        }



    }


    /// <Summary>
    /// Creates grid layouts with tiles that each have a maximum cross-axis extent.
    ///
    /// This delegate will select a cross-axis extent for the tiles that is as
    /// large as possible subject to the following conditions:
    ///
    ///  - The extent evenly divides the cross-axis extent of the grid.
    ///  - The extent is at most [maxCrossAxisExtent].
    ///
    /// For example, if the grid is vertical, the grid is 500.0 pixels wide, and
    /// [maxCrossAxisExtent] is 150.0, this delegate will create a grid with 4
    /// columns that are 125.0 pixels wide.
    ///
    /// This delegate creates grids with equally sized and spaced tiles.
    ///
    /// See also:
    ///
    ///  * [SliverGridDelegateWithFixedCrossAxisCount], which creates a layout with
    ///    a fixed number of tiles in the cross axis.
    ///  * [SliverGridDelegate], which creates arbitrary layouts.
    ///  * [GridView], which can use this delegate to control the layout of its
    ///    tiles.
    ///  * [SliverGrid], which can use this delegate to control the layout of its
    ///    tiles.
    ///  * [RenderSliverGrid], which can use this delegate to control the layout of
    ///    its tiles.
    /// </Summary>
    public class SliverGridDelegateWithMaxCrossAxisExtent : FlutterSDK.Rendering.Slivergrid.SliverGridDelegate
    {
        /// <Summary>
        /// Creates a delegate that makes grid layouts with tiles that have a maximum
        /// cross-axis extent.
        ///
        /// All of the arguments must not be null. The [maxCrossAxisExtent] and
        /// [mainAxisSpacing], and [crossAxisSpacing] arguments must not be negative.
        /// The [childAspectRatio] argument must be greater than zero.
        /// </Summary>
        public SliverGridDelegateWithMaxCrossAxisExtent(double maxCrossAxisExtent = default(double), double mainAxisSpacing = 0.0, double crossAxisSpacing = 0.0, double childAspectRatio = 1.0)
        : base()
        {
            this.MaxCrossAxisExtent = maxCrossAxisExtent;
            this.MainAxisSpacing = mainAxisSpacing;
            this.CrossAxisSpacing = crossAxisSpacing;
            this.ChildAspectRatio = childAspectRatio;
        }
        /// <Summary>
        /// The maximum extent of tiles in the cross axis.
        ///
        /// This delegate will select a cross-axis extent for the tiles that is as
        /// large as possible subject to the following conditions:
        ///
        ///  - The extent evenly divides the cross-axis extent of the grid.
        ///  - The extent is at most [maxCrossAxisExtent].
        ///
        /// For example, if the grid is vertical, the grid is 500.0 pixels wide, and
        /// [maxCrossAxisExtent] is 150.0, this delegate will create a grid with 4
        /// columns that are 125.0 pixels wide.
        /// </Summary>
        public virtual double MaxCrossAxisExtent { get; set; }
        /// <Summary>
        /// The number of logical pixels between each child along the main axis.
        /// </Summary>
        public virtual double MainAxisSpacing { get; set; }
        /// <Summary>
        /// The number of logical pixels between each child along the cross axis.
        /// </Summary>
        public virtual double CrossAxisSpacing { get; set; }
        /// <Summary>
        /// The ratio of the cross-axis to the main-axis extent of each child.
        /// </Summary>
        public virtual double ChildAspectRatio { get; set; }

        private bool _DebugAssertIsValid()
        {




            return true;
        }




        public new FlutterSDK.Rendering.Slivergrid.SliverGridLayout GetLayout(FlutterSDK.Rendering.Sliver.SliverConstraints constraints)
        {

            int crossAxisCount = (constraints.CrossAxisExtent / (MaxCrossAxisExtent + CrossAxisSpacing)).Ceil();
            double usableCrossAxisExtent = constraints.CrossAxisExtent - CrossAxisSpacing * (crossAxisCount - 1);
            double childCrossAxisExtent = usableCrossAxisExtent / crossAxisCount;
            double childMainAxisExtent = childCrossAxisExtent / ChildAspectRatio;
            return new SliverGridRegularTileLayout(crossAxisCount: crossAxisCount, mainAxisStride: childMainAxisExtent + MainAxisSpacing, crossAxisStride: childCrossAxisExtent + CrossAxisSpacing, childMainAxisExtent: childMainAxisExtent, childCrossAxisExtent: childCrossAxisExtent, reverseCrossAxis: BasictypesDefaultClass.AxisDirectionIsReversed(constraints.CrossAxisDirection));
        }




        public new bool ShouldRelayout(FlutterSDK.Rendering.Slivergrid.SliverGridDelegateWithMaxCrossAxisExtent oldDelegate)
        {
            return oldDelegate.MaxCrossAxisExtent != MaxCrossAxisExtent || oldDelegate.MainAxisSpacing != MainAxisSpacing || oldDelegate.CrossAxisSpacing != CrossAxisSpacing || oldDelegate.ChildAspectRatio != ChildAspectRatio;
        }


        public new bool ShouldRelayout(FlutterSDK.Rendering.Slivergrid.SliverGridDelegate oldDelegate)
        {
            return oldDelegate.MaxCrossAxisExtent != MaxCrossAxisExtent || oldDelegate.MainAxisSpacing != MainAxisSpacing || oldDelegate.CrossAxisSpacing != CrossAxisSpacing || oldDelegate.ChildAspectRatio != ChildAspectRatio;
        }



    }


    /// <Summary>
    /// Parent data structure used by [RenderSliverGrid].
    /// </Summary>
    public class SliverGridParentData : FlutterSDK.Rendering.Slivermultiboxadaptor.SliverMultiBoxAdaptorParentData
    {
        public SliverGridParentData()
        { }
        /// <Summary>
        /// The offset of the child in the non-scrolling axis.
        ///
        /// If the scroll axis is vertical, this offset is from the left-most edge of
        /// the parent to the left-most edge of the child. If the scroll axis is
        /// horizontal, this offset is from the top-most edge of the parent to the
        /// top-most edge of the child.
        /// </Summary>
        public virtual double CrossAxisOffset { get; set; }

    }


    /// <Summary>
    /// A sliver that places multiple box children in a two dimensional arrangement.
    ///
    /// [RenderSliverGrid] places its children in arbitrary positions determined by
    /// [gridDelegate]. Each child is forced to have the size specified by the
    /// [gridDelegate].
    ///
    /// See also:
    ///
    ///  * [RenderSliverList], which places its children in a linear
    ///    array.
    ///  * [RenderSliverFixedExtentList], which places its children in a linear
    ///    array with a fixed extent in the main axis.
    /// </Summary>
    public class RenderSliverGrid : FlutterSDK.Rendering.Slivermultiboxadaptor.RenderSliverMultiBoxAdaptor
    {
        /// <Summary>
        /// Creates a sliver that contains multiple box children that whose size and
        /// position are determined by a delegate.
        ///
        /// The [childManager] and [gridDelegate] arguments must not be null.
        /// </Summary>
        public RenderSliverGrid(FlutterSDK.Rendering.Slivermultiboxadaptor.RenderSliverBoxChildManager childManager = default(FlutterSDK.Rendering.Slivermultiboxadaptor.RenderSliverBoxChildManager), FlutterSDK.Rendering.Slivergrid.SliverGridDelegate gridDelegate = default(FlutterSDK.Rendering.Slivergrid.SliverGridDelegate))
        : base(childManager: childManager)
        {

        }
        internal virtual FlutterSDK.Rendering.Slivergrid.SliverGridDelegate _GridDelegate { get; set; }
        public virtual FlutterSDK.Rendering.Slivergrid.SliverGridDelegate GridDelegate { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void SetupParentData(FlutterSDK.Rendering.@object.RenderObject child)
        {
            if (!(child.ParentData is SliverGridParentData)) child.ParentData = new SliverGridParentData();
        }




        public new double ChildCrossAxisPosition(FlutterSDK.Rendering.Box.RenderBox child)
        {
            SliverGridParentData childParentData = child.ParentData as SliverGridParentData;
            return childParentData.CrossAxisOffset;
        }


        public new double ChildCrossAxisPosition(FlutterSDK.Rendering.@object.RenderObject child)
        {
            SliverGridParentData childParentData = child.ParentData as SliverGridParentData;
            return childParentData.CrossAxisOffset;
        }




        public new void PerformLayout()
        {
            SliverConstraints constraints = this.Constraints;
            ChildManager.DidStartLayout();
            ChildManager.SetDidUnderflow(false);
            double scrollOffset = constraints.ScrollOffset + constraints.CacheOrigin;

            double remainingExtent = constraints.RemainingCacheExtent;

            double targetEndScrollOffset = scrollOffset + remainingExtent;
            SliverGridLayout layout = _GridDelegate.GetLayout(constraints);
            int firstIndex = layout.GetMinChildIndexForScrollOffset(scrollOffset);
            int targetLastIndex = targetEndScrollOffset.IsFinite() ? layout.GetMaxChildIndexForScrollOffset(targetEndScrollOffset) : null;
            if (FirstChild != null)
            {
                int oldFirstIndex = IndexOf(FirstChild);
                int oldLastIndex = IndexOf(LastChild);
                int leadingGarbage = (firstIndex - oldFirstIndex).Clamp(0, ChildCount) as int;
                int trailingGarbage = targetLastIndex == null ? 0 : ((oldLastIndex - targetLastIndex).Clamp(0, ChildCount) as int);
                CollectGarbage(leadingGarbage, trailingGarbage);
            }
            else
            {
                CollectGarbage(0, 0);
            }

            SliverGridGeometry firstChildGridGeometry = layout.GetGeometryForChildIndex(firstIndex);
            double leadingScrollOffset = firstChildGridGeometry.ScrollOffset;
            double trailingScrollOffset = firstChildGridGeometry.TrailingScrollOffset;
            if (FirstChild == null)
            {
                if (!AddInitialChild(index: firstIndex, layoutOffset: firstChildGridGeometry.ScrollOffset))
                {
                    double max = layout.ComputeMaxScrollOffset(ChildManager.ChildCount);
                    Geometry = new SliverGeometry(scrollExtent: max, maxPaintExtent: max);
                    ChildManager.DidFinishLayout();
                    return;
                }

            }

            RenderBox trailingChildWithLayout = default(RenderBox);
            for (int index = IndexOf(FirstChild) - 1; index >= firstIndex; --index)
            {
                SliverGridGeometry gridGeometry = layout.GetGeometryForChildIndex(index);
                RenderBox child = InsertAndLayoutLeadingChild(gridGeometry.GetBoxConstraints(constraints));
                SliverGridParentData childParentData = child.ParentData as SliverGridParentData;
                childParentData.LayoutOffset = gridGeometry.ScrollOffset;
                childParentData.CrossAxisOffset = gridGeometry.CrossAxisOffset;

                trailingChildWithLayout = (trailingChildWithLayout == null ? child : trailingChildWithLayout);
                trailingScrollOffset = Dart.Math.MathDefaultClass.Max(trailingScrollOffset, gridGeometry.TrailingScrollOffset);
            }

            if (trailingChildWithLayout == null)
            {
                FirstChild.Layout(firstChildGridGeometry.GetBoxConstraints(constraints));
                SliverGridParentData childParentData = FirstChild.ParentData as SliverGridParentData;
                childParentData.LayoutOffset = firstChildGridGeometry.ScrollOffset;
                childParentData.CrossAxisOffset = firstChildGridGeometry.CrossAxisOffset;
                trailingChildWithLayout = FirstChild;
            }

            for (int index = IndexOf(trailingChildWithLayout) + 1; targetLastIndex == null || index <= targetLastIndex; ++index)
            {
                SliverGridGeometry gridGeometry = layout.GetGeometryForChildIndex(index);
                BoxConstraints childConstraints = gridGeometry.GetBoxConstraints(constraints);
                RenderBox child = ChildAfter(trailingChildWithLayout);
                if (child == null || IndexOf(child) != index)
                {
                    child = InsertAndLayoutChild(childConstraints, after: trailingChildWithLayout);
                    if (child == null)
                    {
                        break;
                    }

                }
                else
                {
                    child.Layout(childConstraints);
                }

                trailingChildWithLayout = child;

                SliverGridParentData childParentData = child.ParentData as SliverGridParentData;
                childParentData.LayoutOffset = gridGeometry.ScrollOffset;
                childParentData.CrossAxisOffset = gridGeometry.CrossAxisOffset;

                trailingScrollOffset = Dart.Math.MathDefaultClass.Max(trailingScrollOffset, gridGeometry.TrailingScrollOffset);
            }

            int lastIndex = IndexOf(LastChild);




            double estimatedTotalExtent = ChildManager.EstimateMaxScrollOffset(constraints, firstIndex: firstIndex, lastIndex: lastIndex, leadingScrollOffset: leadingScrollOffset, trailingScrollOffset: trailingScrollOffset);
            double paintExtent = CalculatePaintOffset(constraints, from: leadingScrollOffset, to: trailingScrollOffset);
            double cacheExtent = CalculateCacheOffset(constraints, from: leadingScrollOffset, to: trailingScrollOffset);
            Geometry = new SliverGeometry(scrollExtent: estimatedTotalExtent, paintExtent: paintExtent, maxPaintExtent: estimatedTotalExtent, cacheExtent: cacheExtent, hasVisualOverflow: true);
            if (estimatedTotalExtent == trailingScrollOffset) ChildManager.SetDidUnderflow(true);
            ChildManager.DidFinishLayout();
        }



    }

}
