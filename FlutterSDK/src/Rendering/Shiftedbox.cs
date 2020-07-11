using System;
using FlutterSDK;
using FlutterSDK.Widgets.Framework;
using System.Net.Http;
using FlutterBinding.UI;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using SkiaSharp;
using FlutterBinding.Engine.Painting;
using static FlutterSDK.Global;
using FlutterBinding.Mapping;
using FlutterSDK.Foundation.Binding;
using FlutterSDK.Foundation.Consolidateresponse;
using FlutterSDK.Foundation.Synchronousfuture;
using FlutterSDK.Foundation.Node;
using FlutterSDK.Foundation.Diagnostics;
using FlutterSDK.Foundation.Profile;
using FlutterSDK.Foundation.@object;
using FlutterSDK.Foundation.Bitfield;
using FlutterSDK.Foundation.Isolates;
using FlutterSDK.Foundation.Platform;
using FlutterSDK.Foundation.Assertions;
using FlutterSDK.Foundation.Debug;
using FlutterSDK.Foundation.Unicode;
using FlutterSDK.Foundation.Observerlist;
using FlutterSDK.Foundation.Key;
using FlutterSDK.Foundation.Stackframe;
using FlutterSDK.Foundation.Print;
using FlutterSDK.Foundation.Changenotifier;
using FlutterSDK.Foundation.Serialization;
using FlutterSDK.Foundation.Annotations;
using FlutterSDK.Foundation.Constants;
using FlutterSDK.Foundation.Licenses;
using FlutterSDK.Foundation.Collections;
using FlutterSDK.Foundation.Basictypes;
using FlutterSDK.Animation.Tween;
using FlutterSDK.Animation.Animation;
using FlutterSDK.Animation.Curves;
using FlutterSDK.Animation.Listenerhelpers;
using FlutterSDK.Physics.Clampedsimulation;
using FlutterSDK.Physics.Frictionsimulation;
using FlutterSDK.Physics.Gravitysimulation;
using FlutterSDK.Physics.Tolerance;
using FlutterSDK.Physics.Simulation;
using FlutterSDK.Physics.Springsimulation;
using FlutterSDK.Physics.Utils;
using FlutterSDK.Scheduler.Binding;
using FlutterSDK.Scheduler.Ticker;
using FlutterSDK.Scheduler.Priority;
using FlutterSDK.Scheduler.Debug;
using FlutterSDK.Semantics.Binding;
using FlutterSDK.Semantics.Debug;
using FlutterSDK.Semantics.Semanticsservice;
using FlutterSDK.Semantics.Semanticsevent;
using FlutterSDK.Semantics.Semantics;
using FlutterSDK.Animation.Animations;
using FlutterSDK.Rendering.Texture;
using FlutterSDK.Gestures.Eager;
using FlutterSDK.Gestures.Debug;
using FlutterSDK.Gestures.Pointerrouter;
using FlutterSDK.Gestures.Recognizer;
using FlutterSDK.Gestures.Dragdetails;
using FlutterSDK.Gestures.Lsqsolver;
using FlutterSDK.Gestures.Scale;
using FlutterSDK.Gestures.Drag;
using FlutterSDK.Gestures.Forcepress;
using FlutterSDK.Gestures.Events;
using FlutterSDK.Gestures.Monodrag;
using FlutterSDK.Gestures.Arena;
using FlutterSDK.Gestures.Multidrag;
using FlutterSDK.Gestures.Constants;
using FlutterSDK.Gestures.Converter;
using FlutterSDK.Gestures.Tap;
using FlutterSDK.Gestures.Binding;
using FlutterSDK.Gestures.Pointersignalresolver;
using FlutterSDK.Gestures.Team;
using FlutterSDK.Gestures.Hittest;
using FlutterSDK.Gestures.Velocitytracker;
using FlutterSDK.Gestures.Multitap;
using FlutterSDK.Gestures.Longpress;
using FlutterSDK.Rendering.Proxybox;
using FlutterSDK.Rendering.Viewportoffset;
using FlutterSDK.Rendering.Flex;
using FlutterSDK.Rendering.Sliverfill;
using FlutterSDK.Rendering.Sliverfixedextentlist;
using FlutterSDK.Rendering.View;
using FlutterSDK.Rendering.Editable;
using FlutterSDK.Rendering.Animatedsize;
using FlutterSDK.Rendering.Custompaint;
using FlutterSDK.Rendering.Performanceoverlay;
using FlutterSDK.Rendering.Sliverpadding;
using FlutterSDK.Rendering.Shiftedbox;
using FlutterSDK.Rendering.Debug;
using FlutterSDK.Rendering.Debugoverflowindicator;
using FlutterSDK.Rendering.Tweens;
using FlutterSDK.Painting.Borders;
using FlutterSDK.Painting.Textstyle;
using FlutterSDK.Painting.Colors;
using FlutterSDK.Painting.Circleborder;
using FlutterSDK.Painting.Edgeinsets;
using FlutterSDK.Painting.Decoration;
using FlutterSDK.Painting.Textspan;
using FlutterSDK.Painting.Strutstyle;
using FlutterSDK.Painting.Beveledrectangleborder;
using FlutterSDK.Painting.Placeholderspan;
using FlutterSDK.Painting.Imagecache;
using FlutterSDK.Painting.Shapedecoration;
using FlutterSDK.Services.Platformviews;
using FlutterSDK.Services.Systemchannels;
using FlutterSDK.Services.Assetbundle;
using FlutterSDK.Services.Binding;
using FlutterSDK.Services.Keyboardkey;
using FlutterSDK.Services.Textformatter;
using FlutterSDK.Services.Rawkeyboardmacos;
using FlutterSDK.Services.Binarymessenger;
using FlutterSDK.Services.Messagecodecs;
using FlutterSDK.Services.Rawkeyboardfuchsia;
using FlutterSDK.Services.Hapticfeedback;
using FlutterSDK.Services.Platformmessages;
using FlutterSDK.Services.Clipboard;
using FlutterSDK.Services.Textediting;
using FlutterSDK.Services.Rawkeyboardlinux;
using FlutterSDK.Services.Textinput;
using FlutterSDK.Services.Rawkeyboardweb;
using FlutterSDK.Services.Rawkeyboard;
using FlutterSDK.Services.Systemchrome;
using FlutterSDK.Services.Systemsound;
using FlutterSDK.Services.Keyboardmaps;
using FlutterSDK.Services.Fontloader;
using FlutterSDK.Services.Systemnavigator;
using FlutterSDK.Services.Rawkeyboardandroid;
using FlutterSDK.Services.Platformchannel;
using FlutterSDK.Services.Messagecodec;
using FlutterSDK.Painting.Textpainter;
using FlutterSDK.Painting.Boxdecoration;
using FlutterSDK.Painting.Paintutilities;
using FlutterSDK.Painting.Stadiumborder;
using FlutterSDK.Painting.Basictypes;
using FlutterSDK.Painting.Alignment;
using FlutterSDK.Painting.Imageprovider;
using FlutterSDK.Painting.Boxfit;
using FlutterSDK.Painting.Continuousrectangleborder;
using FlutterSDK.Painting.Roundedrectangleborder;
using FlutterSDK.Painting.Matrixutils;
using FlutterSDK.Painting.Gradient;
using FlutterSDK.Painting.Notchedshapes;
using FlutterSDK.Painting.Fractionaloffset;
using FlutterSDK.Painting.Borderradius;
using FlutterSDK.Painting.Imageresolution;
using FlutterSDK.Painting.Flutterlogo;
using FlutterSDK.Painting.Imagedecoder;
using FlutterSDK.Painting.Boxshadow;
using FlutterSDK.Painting.Binding;
using FlutterSDK.Painting.Imagestream;
using FlutterSDK.Painting.Boxborder;
using FlutterSDK.Painting.Decorationimage;
using FlutterSDK.Painting.Clip;
using FlutterSDK.Painting.Debug;
using FlutterSDK.Painting.Shaderwarmup;
using FlutterSDK.Painting.Inlinespan;
using FlutterSDK.Painting.Geometry;
using FlutterSDK.Rendering.Image;
using FlutterSDK.Rendering.Box;
using FlutterSDK.Rendering.Slivermultiboxadaptor;
using FlutterSDK.Rendering.Error;
using FlutterSDK.Rendering.Table;
using FlutterSDK.Rendering.Tableborder;
using FlutterSDK.Rendering.Platformview;
using FlutterSDK.Rendering.Binding;
using FlutterSDK.Rendering.Sliverpersistentheader;
using FlutterSDK.Rendering.Listbody;
using FlutterSDK.Rendering.Paragraph;
using FlutterSDK.Rendering.Proxysliver;
using FlutterSDK.Rendering.@object;
using FlutterSDK.Rendering.Rotatedbox;
using FlutterSDK.Rendering.Viewport;
using FlutterSDK.Rendering.Customlayout;
using FlutterSDK.Rendering.Layer;
using FlutterSDK.Rendering.Listwheelviewport;
using FlutterSDK.Rendering.Sliverlist;
using FlutterSDK.Rendering.Flow;
using FlutterSDK.Rendering.Wrap;
using FlutterSDK.Rendering.Sliver;
using FlutterSDK.Rendering.Slivergrid;
using FlutterSDK.Rendering.Stack;
using FlutterSDK.Rendering.Mousetracking;
using FlutterSDK.Widgets.Pages;
using FlutterSDK.Widgets.Performanceoverlay;
using FlutterSDK.Widgets.Automatickeepalive;
using FlutterSDK.Widgets.Scrollcontroller;
using FlutterSDK.Widgets.Widgetinspector;
using FlutterSDK.Widgets.Icon;
using FlutterSDK.Widgets.Scrollcontext;
using FlutterSDK.Widgets.Inheritedmodel;
using FlutterSDK.Widgets.Annotatedregion;
using FlutterSDK.Widgets.Scrollnotification;
using FlutterSDK.Widgets.Scrollpositionwithsinglecontext;
using FlutterSDK.Widgets.Mediaquery;
using FlutterSDK.Widgets.Actions;
using FlutterSDK.Widgets.App;
using FlutterSDK.Widgets.Focusmanager;
using FlutterSDK.Widgets.Visibility;
using FlutterSDK.Widgets.Icondata;
using FlutterSDK.Widgets.Valuelistenablebuilder;
using FlutterSDK.Widgets.Placeholder;
using FlutterSDK.Widgets.Overlay;
using FlutterSDK.Widgets.Focustraversal;
using FlutterSDK.Widgets.Animatedlist;
using FlutterSDK.Widgets.Scrollbar;
using FlutterSDK.Widgets.Iconthemedata;
using FlutterSDK.Widgets.Sliver;
using FlutterSDK.Widgets.Animatedswitcher;
using FlutterSDK.Widgets.Orientationbuilder;
using FlutterSDK.Widgets.Dismissible;
using FlutterSDK.Widgets.Binding;
using FlutterSDK.Widgets.Scrollactivity;
using FlutterSDK.Widgets.Dragtarget;
using FlutterSDK.Widgets.Draggablescrollablesheet;
using FlutterSDK.Widgets.Tweenanimationbuilder;
using FlutterSDK.Widgets.Widgetspan;
using FlutterSDK.Widgets.Image;
using FlutterSDK.Widgets.Title;
using FlutterSDK.Widgets.Willpopscope;
using FlutterSDK.Widgets.Banner;
using FlutterSDK.Widgets.Debug;
using FlutterSDK.Widgets.Imagefilter;
using FlutterSDK.Widgets.Fadeinimage;
using FlutterSDK.Widgets.Sliverlayoutbuilder;
using FlutterSDK.Widgets.Pageview;
using FlutterSDK.Widgets.Heroes;
using FlutterSDK.Widgets.Nestedscrollview;
using FlutterSDK.Widgets.Tickerprovider;
using FlutterSDK.Widgets.Overscrollindicator;
using FlutterSDK.Widgets.Scrollconfiguration;
using FlutterSDK.Widgets.Uniquewidget;
using FlutterSDK.Widgets.Table;
using FlutterSDK.Widgets.Pagestorage;
using FlutterSDK.Widgets.Singlechildscrollview;
using FlutterSDK.Widgets.Gridpaper;
using FlutterSDK.Widgets.Sizechangedlayoutnotifier;
using FlutterSDK.Widgets.Sliverfill;
using FlutterSDK.Widgets.Scrollawareimageprovider;
using FlutterSDK.Widgets.Routes;
using FlutterSDK.Widgets.Texture;
using FlutterSDK.Widgets.Safearea;
using FlutterSDK.Widgets.Navigator;
using FlutterSDK.Widgets.Gesturedetector;
using FlutterSDK.Widgets.Localizations;
using FlutterSDK.Widgets.Animatedcrossfade;
using FlutterSDK.Widgets.Imageicon;
using FlutterSDK.Widgets.Async;
using FlutterSDK.Widgets.Scrollable;
using FlutterSDK.Widgets.Statustransitions;
using FlutterSDK.Widgets.Inheritedtheme;
using FlutterSDK.Widgets.Viewport;
using FlutterSDK.Widgets.Inheritednotifier;
using FlutterSDK.Widgets.Sliverpersistentheader;
using FlutterSDK.Widgets.Colorfilter;
using FlutterSDK.Widgets.Form;
using FlutterSDK.Widgets.Scrollsimulation;
using FlutterSDK.Widgets.Sliverprototypeextentlist;
using FlutterSDK.Widgets.Rawkeyboardlistener;
using FlutterSDK.Widgets.Shortcuts;
using FlutterSDK.Widgets.Bottomnavigationbaritem;
using FlutterSDK.Widgets.Disposablebuildcontext;
using FlutterSDK.Widgets.Scrollmetrics;
using FlutterSDK.Widgets.Modalbarrier;
using FlutterSDK.Widgets.Text;
using FlutterSDK.Widgets.Editabletext;
using FlutterSDK.Widgets.Listwheelscrollview;
using FlutterSDK.Widgets.Notificationlistener;
using FlutterSDK.Widgets.Layoutbuilder;
using FlutterSDK.Widgets.Focusscope;
using FlutterSDK.Widgets.Textselection;
using FlutterSDK.Widgets.Implicitanimations;
using FlutterSDK.Widgets.Icontheme;
using FlutterSDK.Widgets.Container;
using FlutterSDK.Widgets.Primaryscrollcontroller;
using FlutterSDK.Animation.Animationcontroller;
using FlutterSDK.Animation.Tweensequence;
using FlutterSDK.Widgets.Basic;
using FlutterSDK.Widgets.Semanticsdebugger;
using FlutterSDK.Widgets.Navigationtoolbar;
using FlutterSDK.Widgets.Platformview;
using FlutterSDK.Widgets.Transitions;
using FlutterSDK.Widgets.Preferredsize;
using FlutterSDK.Widgets.Scrollphysics;
using FlutterSDK.Widgets.Animatedsize;
using FlutterSDK.Widgets.Scrollposition;
using FlutterSDK.Widgets.Spacer;
using FlutterSDK.Widgets.Scrollview;
using file:///C:/src/xamarin.flutter/flutter/lib/foundation.dart;
using FlutterSDK.Foundation._Bitfieldio;
using FlutterSDK.Foundation._Isolatesio;
using FlutterSDK.Foundation._Platformio;
using FlutterSDK.Material.Appbar;
using FlutterSDK.Material.Debug;
using FlutterSDK.Material.Dialog;
using FlutterSDK.Material.Flatbutton;
using FlutterSDK.Material.Listtile;
using FlutterSDK.Material.Materiallocalizations;
using FlutterSDK.Material.Page;
using FlutterSDK.Material.Progressindicator;
using FlutterSDK.Material.Scaffold;
using FlutterSDK.Material.Scrollbar;
using FlutterSDK.Material.Theme;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Arc;
using FlutterSDK.Material.Colors;
using FlutterSDK.Material.Floatingactionbutton;
using FlutterSDK.Material.Icons;
using FlutterSDK.Material.Appbartheme;
using FlutterSDK.Material.Backbutton;
using FlutterSDK.Material.Constants;
using FlutterSDK.Material.Flexiblespacebar;
using FlutterSDK.Material.Iconbutton;
using FlutterSDK.Material.Material;
using FlutterSDK.Material.Tabs;
using FlutterSDK.Material.Texttheme;
using FlutterSDK.Material.Bannertheme;
using FlutterSDK.Material.Buttonbar;
using FlutterSDK.Material.Buttontheme;
using FlutterSDK.Material.Divider;
using FlutterSDK.Material.Bottomappbartheme;
using FlutterSDK.Material.Elevationoverlay;
using FlutterSDK.Material.Inkwell;
using FlutterSDK.Material.Bottomsheettheme;
using FlutterSDK.Material.Curves;
using FlutterSDK.Material.Materialstate;
using FlutterSDK.Material.Themedata;
using FlutterSDK.Material.Buttonbartheme;
using FlutterSDK.Material.Raisedbutton;
using FlutterSDK.Material.Colorscheme;
using FlutterSDK.Material.Materialbutton;
using FlutterSDK.Material.Outlinebutton;
using FlutterSDK.Material.Cardtheme;
using FlutterSDK.Material.Toggleable;
using FlutterSDK.Material.Checkbox;
using FlutterSDK.Material.Chiptheme;
using FlutterSDK.Material.Feedback;
using FlutterSDK.Material.Tooltip;
using FlutterSDK.Material.Dropdown;
using FlutterSDK.Material.Datatable;
using FlutterSDK.Material.Dialogtheme;
using FlutterSDK.Material.Dividertheme;
using FlutterSDK.Material.Inputdecorator;
using FlutterSDK.Material.Shadows;
using FlutterSDK.Material.Expandicon;
using FlutterSDK.Material.Mergeablematerial;
using FlutterSDK.Material.Button;
using FlutterSDK.Material.Floatingactionbuttontheme;
using FlutterSDK.Material.Inkhighlight;
using FlutterSDK.Material.Inputborder;
using FlutterSDK.Material.Reorderablelist;
using FlutterSDK.Material.Time;
using FlutterSDK.Material.Typography;
using file:///C:/src/xamarin.flutter/flutter/lib/scheduler.dart;
using FlutterSDK.Material.Navigationrailtheme;
using FlutterSDK.Material.Navigationrail;
using FlutterSDK.Material.Pagetransitionstheme;
using FlutterSDK.Material.Card;
using FlutterSDK.Material.Datatablesource;
using FlutterSDK.Material.Inkdecoration;
using FlutterSDK.Material.Pickers.Datepickercommon;
using FlutterSDK.Material.Pickers.Dateutils;
using FlutterSDK.Material.Pickers.Calendardatepicker;
using FlutterSDK.Material.Pickers.Datepickerheader;
using FlutterSDK.Material.Pickers.Inputdatepicker;
using FlutterSDK.Material.Textfield;
using FlutterSDK.Material.Textformfield;
using FlutterSDK.Material.Popupmenutheme;
using FlutterSDK.Material.Radio;
using FlutterSDK.Material.Slidertheme;
using FlutterSDK.Material.Bottomsheet;
using FlutterSDK.Material.Drawer;
using FlutterSDK.Material.Floatingactionbuttonlocation;
using FlutterSDK.Material.Snackbar;
using FlutterSDK.Material.Snackbartheme;
using FlutterSDK.Material.Textselection;
using FlutterSDK.Material.Switch;
using FlutterSDK.Material.Tabbartheme;
using FlutterSDK.Material.Tabcontroller;
using FlutterSDK.Material.Tabindicator;
using FlutterSDK.Material.Selectabletext;
using FlutterSDK.Material.Inksplash;
using FlutterSDK.Material.Togglebuttonstheme;
using FlutterSDK.Material.Tooltiptheme;
using FlutterSDK.Material.Drawerheader;
using FlutterSDK.Painting._Networkimageio;
namespace FlutterSDK.Rendering.Shiftedbox
{
    internal static class ShiftedboxDefaultClass
    {
    }

    /// <Summary>
    /// Abstract class for one-child-layout render boxes that provide control over
    /// the child's position.
    /// </Summary>
    public interface IRenderShiftedBox
    {
        double ComputeMinIntrinsicWidth(double height);
        double ComputeMaxIntrinsicWidth(double height);
        double ComputeMinIntrinsicHeight(double width);
        double ComputeMaxIntrinsicHeight(double width);
        double ComputeDistanceToActualBaseline(TextBaseline baseline);
        void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset);
        bool HitTestChildren(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset));
    }


    /// <Summary>
    /// Abstract class for one-child-layout render boxes that use a
    /// [AlignmentGeometry] to align their children.
    /// </Summary>
    public interface IRenderAligningShiftedBox
    {
        void AlignChild();
        void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties);
        FlutterSDK.Painting.Alignment.AlignmentGeometry Alignment { get; set; }
        TextDirection TextDirection { get; set; }
    }


    /// <Summary>
    /// A delegate for computing the layout of a render object with a single child.
    ///
    /// Used by [CustomSingleChildLayout] (in the widgets library) and
    /// [RenderCustomSingleChildLayoutBox] (in the rendering library).
    ///
    /// When asked to layout, [CustomSingleChildLayout] first calls [getSize] with
    /// its incoming constraints to determine its size. It then calls
    /// [getConstraintsForChild] to determine the constraints to apply to the child.
    /// After the child completes its layout, [RenderCustomSingleChildLayoutBox]
    /// calls [getPositionForChild] to determine the child's position.
    ///
    /// The [shouldRelayout] method is called when a new instance of the class
    /// is provided, to check if the new instance actually represents different
    /// information.
    ///
    /// The most efficient way to trigger a relayout is to supply a `relayout`
    /// argument to the constructor of the [SingleChildLayoutDelegate]. The custom
    /// layout will listen to this value and relayout whenever the Listenable
    /// notifies its listeners, such as when an [Animation] ticks. This allows
    /// the custom layout to avoid the build phase of the pipeline.
    ///
    /// See also:
    ///
    ///  * [CustomSingleChildLayout], the widget that uses this delegate.
    ///  * [RenderCustomSingleChildLayoutBox], render object that uses this
    ///    delegate.
    /// </Summary>
    public interface ISingleChildLayoutDelegate
    {
        Size GetSize(FlutterSDK.Rendering.Box.BoxConstraints constraints);
        FlutterSDK.Rendering.Box.BoxConstraints GetConstraintsForChild(FlutterSDK.Rendering.Box.BoxConstraints constraints);
        Offset GetPositionForChild(Size size, Size childSize);
        bool ShouldRelayout(FlutterSDK.Rendering.Shiftedbox.SingleChildLayoutDelegate oldDelegate);
    }


    /// <Summary>
    /// Abstract class for one-child-layout render boxes that provide control over
    /// the child's position.
    /// </Summary>
    public class RenderShiftedBox : FlutterSDK.Rendering.Box.RenderBox, IRenderObjectWithChildMixin<FlutterSDK.Rendering.Box.RenderBox>
    {
        #region constructors
        public RenderShiftedBox(FlutterSDK.Rendering.Box.RenderBox child)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new double ComputeMinIntrinsicWidth(double height) { throw new NotImplementedException(); }


        public new double ComputeMaxIntrinsicWidth(double height) { throw new NotImplementedException(); }


        public new double ComputeMinIntrinsicHeight(double width) { throw new NotImplementedException(); }


        public new double ComputeMaxIntrinsicHeight(double width) { throw new NotImplementedException(); }


        public new double ComputeDistanceToActualBaseline(TextBaseline baseline) { throw new NotImplementedException(); }


        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset) { throw new NotImplementedException(); }


        public new bool HitTestChildren(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset)) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// Insets its child by the given padding.
    ///
    /// When passing layout constraints to its child, padding shrinks the
    /// constraints by the given padding, causing the child to layout at a smaller
    /// size. Padding then sizes itself to its child's size, inflated by the
    /// padding, effectively creating empty space around the child.
    /// </Summary>
    public class RenderPadding : FlutterSDK.Rendering.Shiftedbox.RenderShiftedBox
    {
        #region constructors
        public RenderPadding(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), TextDirection textDirection = default(TextDirection), FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox))
        : base(child)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual FlutterSDK.Painting.Edgeinsets.EdgeInsets _ResolvedPadding { get; set; }
        internal virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry _Padding { get; set; }
        internal virtual TextDirection _TextDirection { get; set; }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Padding { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual TextDirection TextDirection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        private void _Resolve() { throw new NotImplementedException(); }


        private void _MarkNeedResolution() { throw new NotImplementedException(); }


        public new double ComputeMinIntrinsicWidth(double height) { throw new NotImplementedException(); }


        public new double ComputeMaxIntrinsicWidth(double height) { throw new NotImplementedException(); }


        public new double ComputeMinIntrinsicHeight(double width) { throw new NotImplementedException(); }


        public new double ComputeMaxIntrinsicHeight(double width) { throw new NotImplementedException(); }


        public new void PerformLayout() { throw new NotImplementedException(); }


        public new void DebugPaintSize(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// Abstract class for one-child-layout render boxes that use a
    /// [AlignmentGeometry] to align their children.
    /// </Summary>
    public class RenderAligningShiftedBox : FlutterSDK.Rendering.Shiftedbox.RenderShiftedBox
    {
        #region constructors
        public RenderAligningShiftedBox(FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), TextDirection textDirection = default(TextDirection), FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox))
        : base(child)
        {
            throw new NotImplementedException();
        }
        public static RenderAligningShiftedBox Mixin(FlutterSDK.Painting.Alignment.AlignmentGeometry alignment, TextDirection textDirection, FlutterSDK.Rendering.Box.RenderBox child)
        {
            var instance = new RenderAligningShiftedBox(); throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual FlutterSDK.Painting.Alignment.Alignment _ResolvedAlignment { get; set; }
        internal virtual FlutterSDK.Painting.Alignment.AlignmentGeometry _Alignment { get; set; }
        internal virtual TextDirection _TextDirection { get; set; }
        public virtual FlutterSDK.Painting.Alignment.AlignmentGeometry Alignment { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual TextDirection TextDirection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        private void _Resolve() { throw new NotImplementedException(); }


        private void _MarkNeedResolution() { throw new NotImplementedException(); }


        /// <Summary>
        /// Apply the current [alignment] to the [child].
        ///
        /// Subclasses should call this method if they have a child, to have
        /// this class perform the actual alignment. If there is no child,
        /// do not call this method.
        ///
        /// This method must be called after the child has been laid out and
        /// this object's own size has been set.
        /// </Summary>
        public virtual void AlignChild() { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// Positions its child using an [AlignmentGeometry].
    ///
    /// For example, to align a box at the bottom right, you would pass this box a
    /// tight constraint that is bigger than the child's natural size,
    /// with an alignment of [Alignment.bottomRight].
    ///
    /// By default, sizes to be as big as possible in both axes. If either axis is
    /// unconstrained, then in that direction it will be sized to fit the child's
    /// dimensions. Using widthFactor and heightFactor you can force this latter
    /// behavior in all cases.
    /// </Summary>
    public class RenderPositionedBox : FlutterSDK.Rendering.Shiftedbox.RenderAligningShiftedBox
    {
        #region constructors
        public RenderPositionedBox(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox), double widthFactor = default(double), double heightFactor = default(double), FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), TextDirection textDirection = default(TextDirection))
        : base(child: child, alignment: alignment, textDirection: textDirection)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual double _WidthFactor { get; set; }
        internal virtual double _HeightFactor { get; set; }
        public virtual double WidthFactor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double HeightFactor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void PerformLayout() { throw new NotImplementedException(); }


        public new void DebugPaintSize(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A render object that imposes different constraints on its child than it gets
    /// from its parent, possibly allowing the child to overflow the parent.
    ///
    /// A render overflow box proxies most functions in the render box protocol to
    /// its child, except that when laying out its child, it passes constraints
    /// based on the minWidth, maxWidth, minHeight, and maxHeight fields instead of
    /// just passing the parent's constraints in. Specifically, it overrides any of
    /// the equivalent fields on the constraints given by the parent with the
    /// constraints given by these fields for each such field that is not null. It
    /// then sizes itself based on the parent's constraints' maxWidth and maxHeight,
    /// ignoring the child's dimensions.
    ///
    /// For example, if you wanted a box to always render 50 pixels high, regardless
    /// of where it was rendered, you would wrap it in a
    /// RenderConstrainedOverflowBox with minHeight and maxHeight set to 50.0.
    /// Generally speaking, to avoid confusing behavior around hit testing, a
    /// RenderConstrainedOverflowBox should usually be wrapped in a RenderClipRect.
    ///
    /// The child is positioned according to [alignment]. To position a smaller
    /// child inside a larger parent, use [RenderPositionedBox] and
    /// [RenderConstrainedBox] rather than RenderConstrainedOverflowBox.
    ///
    /// See also:
    ///
    ///  * [RenderUnconstrainedBox] for a render object that allows its children
    ///    to render themselves unconstrained, expands to fit them, and considers
    ///    overflow to be an error.
    ///  * [RenderSizedOverflowBox], a render object that is a specific size but
    ///    passes its original constraints through to its child, which it allows to
    ///    overflow.
    /// </Summary>
    public class RenderConstrainedOverflowBox : FlutterSDK.Rendering.Shiftedbox.RenderAligningShiftedBox
    {
        #region constructors
        public RenderConstrainedOverflowBox(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox), double minWidth = default(double), double maxWidth = default(double), double minHeight = default(double), double maxHeight = default(double), FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), TextDirection textDirection = default(TextDirection))
        : base(child: child, alignment: alignment, textDirection: textDirection)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual double _MinWidth { get; set; }
        internal virtual double _MaxWidth { get; set; }
        internal virtual double _MinHeight { get; set; }
        internal virtual double _MaxHeight { get; set; }
        public virtual double MinWidth { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double MaxWidth { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double MinHeight { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double MaxHeight { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool SizedByParent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        private FlutterSDK.Rendering.Box.BoxConstraints _GetInnerConstraints(FlutterSDK.Rendering.Box.BoxConstraints constraints) { throw new NotImplementedException(); }


        public new void PerformResize() { throw new NotImplementedException(); }


        public new void PerformLayout() { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// Renders a box, imposing no constraints on its child, allowing the child to
    /// render at its "natural" size.
    ///
    /// This allows a child to render at the size it would render if it were alone
    /// on an infinite canvas with no constraints. This box will then attempt to
    /// adopt the same size, within the limits of its own constraints. If it ends
    /// up with a different size, it will align the child based on [alignment].
    /// If the box cannot expand enough to accommodate the entire child, the
    /// child will be clipped.
    ///
    /// In debug mode, if the child overflows the box, a warning will be printed on
    /// the console, and black and yellow striped areas will appear where the
    /// overflow occurs.
    ///
    /// See also:
    ///
    ///  * [RenderConstrainedBox], which renders a box which imposes constraints
    ///    on its child.
    ///  * [RenderConstrainedOverflowBox], which renders a box that imposes different
    ///    constraints on its child than it gets from its parent, possibly allowing
    ///    the child to overflow the parent.
    ///  * [RenderSizedOverflowBox], a render object that is a specific size but
    ///    passes its original constraints through to its child, which it allows to
    ///    overflow.
    /// </Summary>
    public class RenderUnconstrainedBox : FlutterSDK.Rendering.Shiftedbox.RenderAligningShiftedBox, IDebugOverflowIndicatorMixin
    {
        #region constructors
        public RenderUnconstrainedBox(FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), TextDirection textDirection = default(TextDirection), FlutterSDK.Painting.Basictypes.Axis constrainedAxis = default(FlutterSDK.Painting.Basictypes.Axis), FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox))
        : base(alignment, textDirection, child)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual FlutterSDK.Painting.Basictypes.Axis _ConstrainedAxis { get; set; }
        internal virtual FlutterBinding.UI.Rect _OverflowContainerRect { get; set; }
        internal virtual FlutterBinding.UI.Rect _OverflowChildRect { get; set; }
        internal virtual bool _IsOverflowing { get; set; }
        public virtual FlutterSDK.Painting.Basictypes.Axis ConstrainedAxis { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void PerformLayout() { throw new NotImplementedException(); }


        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset) { throw new NotImplementedException(); }


        public new Rect DescribeApproximatePaintClip(FlutterSDK.Rendering.@object.RenderObject child) { throw new NotImplementedException(); }


        public new string ToStringShort() { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A render object that is a specific size but passes its original constraints
    /// through to its child, which it allows to overflow.
    ///
    /// If the child's resulting size differs from this render object's size, then
    /// the child is aligned according to the [alignment] property.
    ///
    /// See also:
    ///
    ///  * [RenderUnconstrainedBox] for a render object that allows its children
    ///    to render themselves unconstrained, expands to fit them, and considers
    ///    overflow to be an error.
    ///  * [RenderConstrainedOverflowBox] for a render object that imposes
    ///    different constraints on its child than it gets from its parent,
    ///    possibly allowing the child to overflow the parent.
    /// </Summary>
    public class RenderSizedOverflowBox : FlutterSDK.Rendering.Shiftedbox.RenderAligningShiftedBox
    {
        #region constructors
        public RenderSizedOverflowBox(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox), Size requestedSize = default(Size), FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), TextDirection textDirection = default(TextDirection))
        : base(child: child, alignment: alignment, textDirection: textDirection)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual Size _RequestedSize { get; set; }
        public virtual Size RequestedSize { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new double ComputeMinIntrinsicWidth(double height) { throw new NotImplementedException(); }


        public new double ComputeMaxIntrinsicWidth(double height) { throw new NotImplementedException(); }


        public new double ComputeMinIntrinsicHeight(double width) { throw new NotImplementedException(); }


        public new double ComputeMaxIntrinsicHeight(double width) { throw new NotImplementedException(); }


        public new double ComputeDistanceToActualBaseline(TextBaseline baseline) { throw new NotImplementedException(); }


        public new void PerformLayout() { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// Sizes its child to a fraction of the total available space.
    ///
    /// For both its width and height, this render object imposes a tight
    /// constraint on its child that is a multiple (typically less than 1.0) of the
    /// maximum constraint it received from its parent on that axis. If the factor
    /// for a given axis is null, then the constraints from the parent are just
    /// passed through instead.
    ///
    /// It then tries to size itself to the size of its child. Where this is not
    /// possible (e.g. if the constraints from the parent are themselves tight), the
    /// child is aligned according to [alignment].
    /// </Summary>
    public class RenderFractionallySizedOverflowBox : FlutterSDK.Rendering.Shiftedbox.RenderAligningShiftedBox
    {
        #region constructors
        public RenderFractionallySizedOverflowBox(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox), double widthFactor = default(double), double heightFactor = default(double), FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), TextDirection textDirection = default(TextDirection))
        : base(child: child, alignment: alignment, textDirection: textDirection)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual double _WidthFactor { get; set; }
        internal virtual double _HeightFactor { get; set; }
        public virtual double WidthFactor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double HeightFactor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        private FlutterSDK.Rendering.Box.BoxConstraints _GetInnerConstraints(FlutterSDK.Rendering.Box.BoxConstraints constraints) { throw new NotImplementedException(); }


        public new double ComputeMinIntrinsicWidth(double height) { throw new NotImplementedException(); }


        public new double ComputeMaxIntrinsicWidth(double height) { throw new NotImplementedException(); }


        public new double ComputeMinIntrinsicHeight(double width) { throw new NotImplementedException(); }


        public new double ComputeMaxIntrinsicHeight(double width) { throw new NotImplementedException(); }


        public new void PerformLayout() { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A delegate for computing the layout of a render object with a single child.
    ///
    /// Used by [CustomSingleChildLayout] (in the widgets library) and
    /// [RenderCustomSingleChildLayoutBox] (in the rendering library).
    ///
    /// When asked to layout, [CustomSingleChildLayout] first calls [getSize] with
    /// its incoming constraints to determine its size. It then calls
    /// [getConstraintsForChild] to determine the constraints to apply to the child.
    /// After the child completes its layout, [RenderCustomSingleChildLayoutBox]
    /// calls [getPositionForChild] to determine the child's position.
    ///
    /// The [shouldRelayout] method is called when a new instance of the class
    /// is provided, to check if the new instance actually represents different
    /// information.
    ///
    /// The most efficient way to trigger a relayout is to supply a `relayout`
    /// argument to the constructor of the [SingleChildLayoutDelegate]. The custom
    /// layout will listen to this value and relayout whenever the Listenable
    /// notifies its listeners, such as when an [Animation] ticks. This allows
    /// the custom layout to avoid the build phase of the pipeline.
    ///
    /// See also:
    ///
    ///  * [CustomSingleChildLayout], the widget that uses this delegate.
    ///  * [RenderCustomSingleChildLayoutBox], render object that uses this
    ///    delegate.
    /// </Summary>
    public class SingleChildLayoutDelegate
    {
        #region constructors
        public SingleChildLayoutDelegate(FlutterSDK.Foundation.Changenotifier.Listenable relayout = default(FlutterSDK.Foundation.Changenotifier.Listenable))
        : base()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual FlutterSDK.Foundation.Changenotifier.Listenable _Relayout { get; set; }
        #endregion

        #region methods

        /// <Summary>
        /// The size of this object given the incoming constraints.
        ///
        /// Defaults to the biggest size that satisfies the given constraints.
        /// </Summary>
        public virtual Size GetSize(FlutterSDK.Rendering.Box.BoxConstraints constraints) { throw new NotImplementedException(); }


        /// <Summary>
        /// The constraints for the child given the incoming constraints.
        ///
        /// During layout, the child is given the layout constraints returned by this
        /// function. The child is required to pick a size for itself that satisfies
        /// these constraints.
        ///
        /// Defaults to the given constraints.
        /// </Summary>
        public virtual FlutterSDK.Rendering.Box.BoxConstraints GetConstraintsForChild(FlutterSDK.Rendering.Box.BoxConstraints constraints) { throw new NotImplementedException(); }


        /// <Summary>
        /// The position where the child should be placed.
        ///
        /// The `size` argument is the size of the parent, which might be different
        /// from the value returned by [getSize] if that size doesn't satisfy the
        /// constraints passed to [getSize]. The `childSize` argument is the size of
        /// the child, which will satisfy the constraints returned by
        /// [getConstraintsForChild].
        ///
        /// Defaults to positioning the child in the upper left corner of the parent.
        /// </Summary>
        public virtual Offset GetPositionForChild(Size size, Size childSize) { throw new NotImplementedException(); }


        /// <Summary>
        /// Called whenever a new instance of the custom layout delegate class is
        /// provided to the [RenderCustomSingleChildLayoutBox] object, or any time
        /// that a new [CustomSingleChildLayout] object is created with a new instance
        /// of the custom layout delegate class (which amounts to the same thing,
        /// because the latter is implemented in terms of the former).
        ///
        /// If the new instance represents different information than the old
        /// instance, then the method should return true, otherwise it should return
        /// false.
        ///
        /// If the method returns false, then the [getSize],
        /// [getConstraintsForChild], and [getPositionForChild] calls might be
        /// optimized away.
        ///
        /// It's possible that the layout methods will get called even if
        /// [shouldRelayout] returns false (e.g. if an ancestor changed its layout).
        /// It's also possible that the layout method will get called
        /// without [shouldRelayout] being called at all (e.g. if the parent changes
        /// size).
        /// </Summary>
        public virtual bool ShouldRelayout(FlutterSDK.Rendering.Shiftedbox.SingleChildLayoutDelegate oldDelegate) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// Defers the layout of its single child to a delegate.
    ///
    /// The delegate can determine the layout constraints for the child and can
    /// decide where to position the child. The delegate can also determine the size
    /// of the parent, but the size of the parent cannot depend on the size of the
    /// child.
    /// </Summary>
    public class RenderCustomSingleChildLayoutBox : FlutterSDK.Rendering.Shiftedbox.RenderShiftedBox
    {
        #region constructors
        public RenderCustomSingleChildLayoutBox(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Rendering.Shiftedbox.SingleChildLayoutDelegate @delegate = default(FlutterSDK.Rendering.Shiftedbox.SingleChildLayoutDelegate))
        : base(child)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual FlutterSDK.Rendering.Shiftedbox.SingleChildLayoutDelegate _Delegate { get; set; }
        public virtual FlutterSDK.Rendering.Shiftedbox.SingleChildLayoutDelegate @delegate { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void Attach(FlutterSDK.Rendering.@object.PipelineOwner owner) { throw new NotImplementedException(); }
        public new void Attach(@Object owner) { throw new NotImplementedException(); }


        public new void Detach() { throw new NotImplementedException(); }


        private Size _GetSize(FlutterSDK.Rendering.Box.BoxConstraints constraints) { throw new NotImplementedException(); }


        public new double ComputeMinIntrinsicWidth(double height) { throw new NotImplementedException(); }


        public new double ComputeMaxIntrinsicWidth(double height) { throw new NotImplementedException(); }


        public new double ComputeMinIntrinsicHeight(double width) { throw new NotImplementedException(); }


        public new double ComputeMaxIntrinsicHeight(double width) { throw new NotImplementedException(); }


        public new void PerformLayout() { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// Shifts the child down such that the child's baseline (or the
    /// bottom of the child, if the child has no baseline) is [baseline]
    /// logical pixels below the top of this box, then sizes this box to
    /// contain the child.
    ///
    /// If [baseline] is less than the distance from the top of the child
    /// to the baseline of the child, then the child will overflow the top
    /// of the box. This is typically not desirable, in particular, that
    /// part of the child will not be found when doing hit tests, so the
    /// user cannot interact with that part of the child.
    ///
    /// This box will be sized so that its bottom is coincident with the
    /// bottom of the child. This means if this box shifts the child down,
    /// there will be space between the top of this box and the top of the
    /// child, but there is never space between the bottom of the child
    /// and the bottom of the box.
    /// </Summary>
    public class RenderBaseline : FlutterSDK.Rendering.Shiftedbox.RenderShiftedBox
    {
        #region constructors
        public RenderBaseline(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox), double baseline = default(double), TextBaseline baselineType = default(TextBaseline))
        : base(child)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual double _Baseline { get; set; }
        internal virtual TextBaseline _BaselineType { get; set; }
        public virtual double Baseline { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual TextBaseline BaselineType { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void PerformLayout() { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }

}
