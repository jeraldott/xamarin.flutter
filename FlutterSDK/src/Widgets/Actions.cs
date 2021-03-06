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
namespace FlutterSDK.Widgets.Actions
{
    /// <Summary>
    /// Creates actions for use in defining shortcuts.
    ///
    /// Used by clients of [ShortcutMap] to define shortcut maps.
    /// </Summary>
    public delegate FlutterSDK.Widgets.Actions.Action ActionFactory();
    /// <Summary>
    /// The signature of a callback accepted by [CallbackAction].
    /// </Summary>
    public delegate void OnInvokeCallback(FlutterSDK.Widgets.Focusmanager.FocusNode node, FlutterSDK.Widgets.Actions.Intent tag);
    internal static class ActionsDefaultClass
    {
    }

    /// <Summary>
    /// Base class for actions.
    ///
    /// As the name implies, an [Action] is an action or command to be performed.
    /// They are typically invoked as a result of a user action, such as a keyboard
    /// shortcut in a [Shortcuts] widget, which is used to look up an [Intent],
    /// which is given to an [ActionDispatcher] to map the [Intent] to an [Action]
    /// and invoke it.
    ///
    /// The [ActionDispatcher] can invoke an [Action] on the primary focus, or
    /// without regard for focus.
    ///
    /// See also:
    ///
    ///  * [Shortcuts], which is a widget that contains a key map, in which it looks
    ///    up key combinations in order to invoke actions.
    ///  * [Actions], which is a widget that defines a map of [Intent] to [Action]
    ///    and allows redefining of actions for its descendants.
    ///  * [ActionDispatcher], a class that takes an [Action] and invokes it using a
    ///    [FocusNode] for context.
    /// </Summary>
    public interface IAction
    {
        void Invoke(FlutterSDK.Widgets.Focusmanager.FocusNode node, FlutterSDK.Widgets.Actions.Intent intent);
        void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties);
        FlutterSDK.Foundation.Key.LocalKey IntentKey { get; }
    }


    /// <Summary>
    /// An action that invokes the currently focused control.
    ///
    /// This is an abstract class that serves as a base class for actions that
    /// activate a control. By default, is bound to [LogicalKeyboardKey.enter] in
    /// the default keyboard map in [WidgetsApp].
    /// </Summary>
    public interface IActivateAction
    {
        FlutterSDK.Foundation.Key.LocalKey Key { get; }
    }


    /// <Summary>
    /// An action that selects the currently focused control.
    ///
    /// This is an abstract class that serves as a base class for actions that
    /// select something. It is not bound to any key by default.
    /// </Summary>
    public interface ISelectAction
    {
        FlutterSDK.Foundation.Key.LocalKey Key { get; }
    }


    /// <Summary>
    /// A class representing a particular configuration of an action.
    ///
    /// This class is what a key map in a [ShortcutMap] has as values, and is used
    /// by an [ActionDispatcher] to look up an action and invoke it, giving it this
    /// object to extract configuration information from.
    ///
    /// If this intent returns false from [isEnabled], then its associated action will
    /// not be invoked if requested.
    /// </Summary>
    public class Intent : IDiagnosticable
    {
        /// <Summary>
        /// A const constructor for an [Intent].
        ///
        /// The [key] argument must not be null.
        /// </Summary>
        public Intent(FlutterSDK.Foundation.Key.LocalKey key)
        : base()
        {
            this.Key = key;
        }
        /// <Summary>
        /// An intent that can't be mapped to an action.
        ///
        /// This Intent is mapped to an action in the [WidgetsApp] that does nothing,
        /// so that it can be bound to a key in a [Shortcuts] widget in order to
        /// disable a key binding made above it in the hierarchy.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Actions.Intent DoNothing { get; set; }
        /// <Summary>
        /// The key for the action this intent is associated with.
        /// </Summary>
        public virtual FlutterSDK.Foundation.Key.LocalKey Key { get; set; }

        /// <Summary>
        /// Returns true if the associated action is able to be executed in the
        /// given `context`.
        ///
        /// Returns true by default.
        /// </Summary>
        public virtual bool IsEnabled(FlutterSDK.Widgets.Framework.BuildContext context) => true;



        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DiagnosticsProperty<LocalKey>("key", Key));
        }



    }


    /// <Summary>
    /// Base class for actions.
    ///
    /// As the name implies, an [Action] is an action or command to be performed.
    /// They are typically invoked as a result of a user action, such as a keyboard
    /// shortcut in a [Shortcuts] widget, which is used to look up an [Intent],
    /// which is given to an [ActionDispatcher] to map the [Intent] to an [Action]
    /// and invoke it.
    ///
    /// The [ActionDispatcher] can invoke an [Action] on the primary focus, or
    /// without regard for focus.
    ///
    /// See also:
    ///
    ///  * [Shortcuts], which is a widget that contains a key map, in which it looks
    ///    up key combinations in order to invoke actions.
    ///  * [Actions], which is a widget that defines a map of [Intent] to [Action]
    ///    and allows redefining of actions for its descendants.
    ///  * [ActionDispatcher], a class that takes an [Action] and invokes it using a
    ///    [FocusNode] for context.
    /// </Summary>
    public class Action : IDiagnosticable
    {
        /// <Summary>
        /// A const constructor for an [Action].
        ///
        /// The [intentKey] parameter must not be null.
        /// </Summary>
        public Action(FlutterSDK.Foundation.Key.LocalKey intentKey)
        : base()
        {
            this.IntentKey = intentKey;
        }
        /// <Summary>
        /// The unique key for this action.
        ///
        /// This key will be used to map to this action in an [ActionDispatcher].
        /// </Summary>
        public virtual FlutterSDK.Foundation.Key.LocalKey IntentKey { get; set; }

        /// <Summary>
        /// Called when the action is to be performed.
        ///
        /// This is called by the [ActionDispatcher] when an action is accepted by a
        /// [FocusNode] by returning true from its `onAction` callback, or when an
        /// action is invoked using [ActionDispatcher.invokeAction].
        ///
        /// This method is only meant to be invoked by an [ActionDispatcher], or by
        /// subclasses.
        ///
        /// Actions invoked directly with [ActionDispatcher.invokeAction] may receive a
        /// null `node`. If the information available from a focus node is
        /// needed in the action, use [ActionDispatcher.invokeFocusedAction] instead.
        /// </Summary>
        public virtual void Invoke(FlutterSDK.Widgets.Focusmanager.FocusNode node, FlutterSDK.Widgets.Actions.Intent intent)
        {
        }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DiagnosticsProperty<LocalKey>("intentKey", IntentKey));
        }



    }


    /// <Summary>
    /// An [Action] that takes a callback in order to configure it without having to
    /// subclass it.
    ///
    /// See also:
    ///
    ///  * [Shortcuts], which is a widget that contains a key map, in which it looks
    ///    up key combinations in order to invoke actions.
    ///  * [Actions], which is a widget that defines a map of [Intent] to [Action]
    ///    and allows redefining of actions for its descendants.
    ///  * [ActionDispatcher], a class that takes an [Action] and invokes it using a
    ///    [FocusNode] for context.
    /// </Summary>
    public class CallbackAction : FlutterSDK.Widgets.Actions.Action
    {
        /// <Summary>
        /// A const constructor for an [Action].
        ///
        /// The `intentKey` and [onInvoke] parameters must not be null.
        /// The [onInvoke] parameter is required.
        /// </Summary>
        public CallbackAction(FlutterSDK.Foundation.Key.LocalKey intentKey, FlutterSDK.Widgets.Actions.OnInvokeCallback onInvoke = default(FlutterSDK.Widgets.Actions.OnInvokeCallback))
        : base(intentKey)
        {
            this.OnInvoke = onInvoke;
        }
        /// <Summary>
        /// The callback to be called when invoked.
        ///
        /// Must not be null.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Actions.OnInvokeCallback OnInvoke { get; set; }

        public new void Invoke(FlutterSDK.Widgets.Focusmanager.FocusNode node, FlutterSDK.Widgets.Actions.Intent intent) => OnInvoke.OnInvoke(node, intent);


    }


    /// <Summary>
    /// An action manager that simply invokes the actions given to it.
    /// </Summary>
    public class ActionDispatcher : IDiagnosticable
    {
        /// <Summary>
        /// Const constructor so that subclasses can be const.
        /// </Summary>
        public ActionDispatcher()
        {

        }

        /// <Summary>
        /// Invokes the given action, optionally without regard for the currently
        /// focused node in the focus tree.
        ///
        /// Actions invoked will receive the given `focusNode`, or the
        /// [FocusManager.primaryFocus] if the given `focusNode` is null.
        ///
        /// The `action` and `intent` arguments must not be null.
        ///
        /// Returns true if the action was successfully invoked.
        /// </Summary>
        public virtual bool InvokeAction(FlutterSDK.Widgets.Actions.Action action, FlutterSDK.Widgets.Actions.Intent intent, FlutterSDK.Widgets.Focusmanager.FocusNode focusNode = default(FlutterSDK.Widgets.Focusmanager.FocusNode))
        {


            focusNode = (focusNode == null ? FocusmanagerDefaultClass.PrimaryFocus : focusNode);
            if (action != null && intent.IsEnabled(focusNode.Context))
            {
                action.Invoke(focusNode, intent);
                return true;
            }

            return false;
        }



    }


    /// <Summary>
    /// A widget that establishes an [ActionDispatcher] and a map of [Intent] to
    /// [Action] to be used by its descendants when invoking an [Action].
    ///
    /// Actions are typically invoked using [Actions.invoke] with the context
    /// containing the ambient [Actions] widget.
    ///
    /// See also:
    ///
    ///  * [ActionDispatcher], the object that this widget uses to manage actions.
    ///  * [Action], a class for containing and defining an invocation of a user
    ///    action.
    ///  * [Intent], a class that holds a unique [LocalKey] identifying an action,
    ///    as well as configuration information for running the [Action].
    ///  * [Shortcuts], a widget used to bind key combinations to [Intent]s.
    /// </Summary>
    public class Actions : FlutterSDK.Widgets.Framework.InheritedWidget
    {
        /// <Summary>
        /// Creates an [Actions] widget.
        ///
        /// The [child], [actions], and [dispatcher] arguments must not be null.
        /// </Summary>
        public Actions(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Actions.ActionDispatcher dispatcher = default(FlutterSDK.Widgets.Actions.ActionDispatcher), Dictionary<FlutterSDK.Foundation.Key.LocalKey, object> actions = default(Dictionary<FlutterSDK.Foundation.Key.LocalKey, object>), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Dispatcher = dispatcher;
            this.ActionsValue = actions;
        }
        /// <Summary>
        /// The [ActionDispatcher] object that invokes actions.
        ///
        /// This is what is returned from [Actions.of], and used by [Actions.invoke].
        ///
        /// If this [dispatcher] is null, then [Actions.of] and [Actions.invoke] will
        /// look up the tree until they find an Actions widget that has a dispatcher
        /// set. If not such widget is found, then they will return/use a
        /// default-constructed [ActionDispatcher].
        /// </Summary>
        public virtual FlutterSDK.Widgets.Actions.ActionDispatcher Dispatcher { get; set; }
        /// <Summary>
        /// {@template flutter.widgets.actions.actions}
        /// A map of [Intent] keys to [ActionFactory] factory methods that defines
        /// which actions this widget knows about.
        ///
        /// For performance reasons, it is recommended that a pre-built map is
        /// passed in here (e.g. a final variable from your widget class) instead of
        /// defining it inline in the build function.
        /// {@endtemplate}
        /// </Summary>
        public virtual Dictionary<FlutterSDK.Foundation.Key.LocalKey, object> ActionsValue { get; set; }

        private FlutterSDK.Widgets.Actions.ActionDispatcher _FindDispatcher(FlutterSDK.Widgets.Framework.Element element)
        {

            Actions actions = element.Widget as Actions;
            ActionDispatcher dispatcher = actions.Dispatcher;
            if (dispatcher == null)
            {
                bool VisitAncestorElement(Element visitedElement)
                {
                    if (!(((Actions)visitedElement.Widget) is Actions))
                    {
                        return true;
                    }

                    Actions actions = visitedElement.Widget as Actions;
                    if (actions.Dispatcher == null)
                    {
                        return true;
                    }

                    dispatcher = actions.Dispatcher;
                    return false;
                }

                element.VisitAncestorElements(VisitAncestorElement);
            }

            return dispatcher ?? new ActionDispatcher();
        }




        /// <Summary>
        /// Returns the [ActionDispatcher] associated with the [Actions] widget that
        /// most tightly encloses the given [BuildContext].
        ///
        /// Will throw if no ambient [Actions] widget is found.
        ///
        /// If `nullOk` is set to true, then if no ambient [Actions] widget is found,
        /// this will return null.
        ///
        /// The `context` argument must not be null.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Actions.ActionDispatcher Of(FlutterSDK.Widgets.Framework.BuildContext context, bool nullOk = false)
        {

            InheritedElement inheritedElement = context.GetElementForInheritedWidgetOfExactType();
            Actions inherited = context.DependOnInheritedElement(inheritedElement) as Actions;

            return inherited?.Dispatcher ?? _FindDispatcher(inheritedElement);
        }




        /// <Summary>
        /// Invokes the action associated with the given [Intent] using the
        /// [Actions] widget that most tightly encloses the given [BuildContext].
        ///
        /// The `context`, `intent` and `nullOk` arguments must not be null.
        ///
        /// If the given `intent` isn't found in the first [Actions.actions] map, then
        /// it will move up to the next [Actions] widget in the hierarchy until it
        /// reaches the root.
        ///
        /// Will throw if no ambient [Actions] widget is found, or if the given
        /// `intent` doesn't map to an action in any of the [Actions.actions] maps
        /// that are found.
        ///
        /// Returns true if an action was successfully invoked.
        ///
        /// Setting `nullOk` to true means that if no ambient [Actions] widget is
        /// found, then this method will return false instead of throwing.
        /// </Summary>
        public virtual bool Invoke(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Actions.Intent intent, FlutterSDK.Widgets.Focusmanager.FocusNode focusNode = default(FlutterSDK.Widgets.Focusmanager.FocusNode), bool nullOk = false)
        {


            Element actionsElement = default(Element);
            Action action = default(Action);
            bool VisitAncestorElement(Element element)
            {
                if (!(element.Widget is Actions))
                {
                    return true;
                }

                actionsElement = element;
                Actions actions = element.Widget as Actions;
                action = actions.Actions[intent.Key]?.Call();
                return action == null;
            }

            context.VisitAncestorElements(VisitAncestorElement);

            if (action == null)
            {
                return false;
            }

            return _FindDispatcher(actionsElement).InvokeAction(action, intent, focusNode: focusNode);
        }




        public new bool UpdateShouldNotify(FlutterSDK.Widgets.Actions.Actions oldWidget)
        {
            return oldWidget.Dispatcher != Dispatcher || !CollectionsDefaultClass.MapEquals(oldWidget.Actions, Actions);
        }


        public new bool UpdateShouldNotify(FlutterSDK.Widgets.Framework.InheritedWidget oldWidget)
        {
            return oldWidget.Dispatcher != Dispatcher || !CollectionsDefaultClass.MapEquals(oldWidget.Actions, Actions);
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DiagnosticsProperty<ActionDispatcher>("dispatcher", Dispatcher));
            properties.Add(new DiagnosticsProperty<Dictionary<LocalKey, ActionFactory>>("actions", Actions));
        }



    }


    /// <Summary>
    /// A widget that combines the functionality of [Actions], [Shortcuts],
    /// [MouseRegion] and a [Focus] widget to create a detector that defines actions
    /// and key bindings, and provides callbacks for handling focus and hover
    /// highlights.
    ///
    /// This widget can be used to give a control the required detection modes for
    /// focus and hover handling. It is most often used when authoring a new control
    /// widget, and the new control should be enabled for keyboard traversal and
    /// activation.
    ///
    /// {@tool dartpad --template=stateful_widget_material}
    /// This example shows how keyboard interaction can be added to a custom control
    /// that changes color when hovered and focused, and can toggle a light when
    /// activated, either by touch or by hitting the `X` key on the keyboard when
    /// the "And Me" button has the keyboard focus (be sure to use TAB to move the
    /// focus to the "And Me" button before trying it out).
    ///
    /// This example defines its own key binding for the `X` key, but in this case,
    /// there is also a default key binding for [ActivateAction] in the default key
    /// bindings created by [WidgetsApp] (the parent for [MaterialApp], and
    /// [CupertinoApp]), so the `ENTER` key will also activate the buttons.
    ///
    /// ```dart imports
    /// import 'package:flutter/services.dart';
    /// ```
    ///
    /// ```dart preamble
    /// class FadButton extends StatefulWidget {
    ///   const FadButton({Key key, this.onPressed, this.child}) : super(key: key);
    ///
    ///   final VoidCallback onPressed;
    ///   final Widget child;
    ///
    ///   @override
    ///   _FadButtonState createState() => _FadButtonState();
    /// }
    ///
    /// class _FadButtonState extends State<FadButton> {
    ///   bool _focused = false;
    ///   bool _hovering = false;
    ///   bool _on = false;
    ///   Map<LocalKey, ActionFactory> _actionMap;
    ///   Map<LogicalKeySet, Intent> _shortcutMap;
    ///
    ///   @override
    ///   void initState() {
    ///     super.initState();
    ///     _actionMap = <LocalKey, ActionFactory>{
    ///       ActivateAction.key: () {
    ///         return CallbackAction(
    ///           ActivateAction.key,
    ///           onInvoke: (FocusNode node, Intent intent) => _toggleState(),
    ///         );
    ///       },
    ///     };
    ///     _shortcutMap = <LogicalKeySet, Intent>{
    ///       LogicalKeySet(LogicalKeyboardKey.keyX): Intent(ActivateAction.key),
    ///     };
    ///   }
    ///
    ///   Color get color {
    ///     Color baseColor = Colors.lightBlue;
    ///     if (_focused) {
    ///       baseColor = Color.alphaBlend(Colors.black.withOpacity(0.25), baseColor);
    ///     }
    ///     if (_hovering) {
    ///       baseColor = Color.alphaBlend(Colors.black.withOpacity(0.1), baseColor);
    ///     }
    ///     return baseColor;
    ///   }
    ///
    ///   void _toggleState() {
    ///     setState(() {
    ///       _on = !_on;
    ///     });
    ///   }
    ///
    ///   void _handleFocusHighlight(bool value) {
    ///     setState(() {
    ///       _focused = value;
    ///     });
    ///   }
    ///
    ///   void _handleHoveHighlight(bool value) {
    ///     setState(() {
    ///       _hovering = value;
    ///     });
    ///   }
    ///
    ///   @override
    ///   Widget build(BuildContext context) {
    ///     return GestureDetector(
    ///       onTap: _toggleState,
    ///       child: FocusableActionDetector(
    ///         actions: _actionMap,
    ///         shortcuts: _shortcutMap,
    ///         onShowFocusHighlight: _handleFocusHighlight,
    ///         onShowHoverHighlight: _handleHoveHighlight,
    ///         child: Row(
    ///           children: <Widget>[
    ///             Container(
    ///               padding: EdgeInsets.all(10.0),
    ///               color: color,
    ///               child: widget.child,
    ///             ),
    ///             Container(
    ///               width: 30,
    ///               height: 30,
    ///               margin: EdgeInsets.all(10.0),
    ///               color: _on ? Colors.red : Colors.transparent,
    ///             ),
    ///           ],
    ///         ),
    ///       ),
    ///     );
    ///   }
    /// }
    /// ```
    ///
    /// ```dart
    /// Widget build(BuildContext context) {
    ///   return Scaffold(
    ///     appBar: AppBar(
    ///       title: Text('FocusableActionDetector Example'),
    ///     ),
    ///     body: Center(
    ///       child: Row(
    ///         mainAxisAlignment: MainAxisAlignment.center,
    ///         children: <Widget>[
    ///           Padding(
    ///             padding: const EdgeInsets.all(8.0),
    ///             child: FlatButton(onPressed: () {}, child: Text('Press Me')),
    ///           ),
    ///           Padding(
    ///             padding: const EdgeInsets.all(8.0),
    ///             child: FadButton(onPressed: () {}, child: Text('And Me')),
    ///           ),
    ///         ],
    ///       ),
    ///     ),
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// This widget doesn't have any visual representation, it is just a detector that
    /// provides focus and hover capabilities.
    ///
    /// It hosts its own [FocusNode] or uses [focusNode], if given.
    /// </Summary>
    public class FocusableActionDetector : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        /// <Summary>
        /// Create a const [FocusableActionDetector].
        ///
        /// The [enabled], [autofocus], and [child] arguments must not be null.
        /// </Summary>
        public FocusableActionDetector(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), bool enabled = true, FlutterSDK.Widgets.Focusmanager.FocusNode focusNode = default(FlutterSDK.Widgets.Focusmanager.FocusNode), bool autofocus = false, Dictionary<FlutterSDK.Widgets.Shortcuts.LogicalKeySet, FlutterSDK.Widgets.Actions.Intent> shortcuts = default(Dictionary<FlutterSDK.Widgets.Shortcuts.LogicalKeySet, FlutterSDK.Widgets.Actions.Intent>), Dictionary<FlutterSDK.Foundation.Key.LocalKey, object> actions = default(Dictionary<FlutterSDK.Foundation.Key.LocalKey, object>), FlutterSDK.Foundation.Basictypes.ValueChanged<bool> onShowFocusHighlight = default(FlutterSDK.Foundation.Basictypes.ValueChanged<bool>), FlutterSDK.Foundation.Basictypes.ValueChanged<bool> onShowHoverHighlight = default(FlutterSDK.Foundation.Basictypes.ValueChanged<bool>), FlutterSDK.Foundation.Basictypes.ValueChanged<bool> onFocusChange = default(FlutterSDK.Foundation.Basictypes.ValueChanged<bool>), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.Enabled = enabled;
            this.FocusNode = focusNode;
            this.Autofocus = autofocus;
            this.Shortcuts = shortcuts;
            this.Actions = actions;
            this.OnShowFocusHighlight = onShowFocusHighlight;
            this.OnShowHoverHighlight = onShowHoverHighlight;
            this.OnFocusChange = onFocusChange;
            this.Child = child;
        }
        /// <Summary>
        /// Is this widget enabled or not.
        ///
        /// If disabled, will not send any notifications needed to update highlight or
        /// focus state, and will not define or respond to any actions or shortcuts.
        ///
        /// When disabled, adds [Focus] to the widget tree, but sets
        /// [Focus.canRequestFocus] to false.
        /// </Summary>
        public virtual bool Enabled { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.Focus.focusNode}
        /// </Summary>
        public virtual FlutterSDK.Widgets.Focusmanager.FocusNode FocusNode { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.Focus.autofocus}
        /// </Summary>
        public virtual bool Autofocus { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.actions.actions}
        /// </Summary>
        public virtual Dictionary<FlutterSDK.Foundation.Key.LocalKey, object> Actions { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.shortcuts.shortcuts}
        /// </Summary>
        public virtual Dictionary<FlutterSDK.Widgets.Shortcuts.LogicalKeySet, FlutterSDK.Widgets.Actions.Intent> Shortcuts { get; set; }
        /// <Summary>
        /// A function that will be called when the focus highlight should be shown or
        /// hidden.
        ///
        /// This method is not triggered at the unmount of the widget.
        /// </Summary>
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<bool> OnShowFocusHighlight { get; set; }
        /// <Summary>
        /// A function that will be called when the hover highlight should be shown or hidden.
        ///
        /// This method is not triggered at the unmount of the widget.
        /// </Summary>
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<bool> OnShowHoverHighlight { get; set; }
        /// <Summary>
        /// A function that will be called when the focus changes.
        ///
        /// Called with true if the [focusNode] has primary focus.
        /// </Summary>
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<bool> OnFocusChange { get; set; }
        /// <Summary>
        /// The child widget for this [FocusableActionDetector] widget.
        ///
        /// {@macro flutter.widgets.child}
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }

        public new FlutterSDK.Widgets.Actions._FocusableActionDetectorState CreateState() => new _FocusableActionDetectorState();


    }


    public class _FocusableActionDetectorState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Actions.FocusableActionDetector>
    {
        public _FocusableActionDetectorState()
        { }
        internal virtual bool _CanShowHighlight { get; set; }
        internal virtual bool _Hovering { get; set; }
        internal virtual bool _Focused { get; set; }

        public new void InitState()
        {
            base.InitState();
            BindingDefaultClass.SchedulerBinding.Instance.AddPostFrameCallback((TimeSpan duration) =>
            {
                _UpdateHighlightMode(FocusmanagerDefaultClass.FocusManager.Instance.HighlightMode);
            }
            );
            FocusmanagerDefaultClass.FocusManager.Instance.AddHighlightModeListener(_HandleFocusHighlightModeChange);
        }




        public new void Dispose()
        {
            FocusmanagerDefaultClass.FocusManager.Instance.RemoveHighlightModeListener(_HandleFocusHighlightModeChange);
            base.Dispose();
        }




        private void _UpdateHighlightMode(FlutterSDK.Widgets.Focusmanager.FocusHighlightMode mode)
        {
            _MayTriggerCallback(task: () =>
            {
                switch (FocusmanagerDefaultClass.FocusManager.Instance.HighlightMode) { case FocusHighlightMode.Touch: _CanShowHighlight = false; break; case FocusHighlightMode.Traditional: _CanShowHighlight = true; break; }
            }
            );
        }




        private void _HandleFocusHighlightModeChange(FlutterSDK.Widgets.Focusmanager.FocusHighlightMode mode)
        {
            if (!Mounted)
            {
                return;
            }

            _UpdateHighlightMode(mode);
        }




        private void _HandleMouseEnter(FlutterSDK.Gestures.Events.PointerEnterEvent @event)
        {

            if (!_Hovering)
            {
                _MayTriggerCallback(task: () =>
                {
                    _Hovering = true;
                }
                );
            }

        }




        private void _HandleMouseExit(FlutterSDK.Gestures.Events.PointerExitEvent @event)
        {

            if (_Hovering)
            {
                _MayTriggerCallback(task: () =>
                {
                    _Hovering = false;
                }
                );
            }

        }




        private void _HandleFocusChange(bool focused)
        {
            if (_Focused != focused)
            {
                _MayTriggerCallback(task: () =>
                {
                    _Focused = focused;
                }
                );
                Widget.OnFocusChange?.Call(_Focused);
            }

        }




        private void _MayTriggerCallback(VoidCallback task = default(VoidCallback), FlutterSDK.Widgets.Actions.FocusableActionDetector oldWidget = default(FlutterSDK.Widgets.Actions.FocusableActionDetector))
        {
            bool ShouldShowHoverHighlight(FocusableActionDetector target)
            {
                return _Hovering && target.Enabled && _CanShowHighlight;
            }

            bool ShouldShowFocusHighlight(FocusableActionDetector target)
            {
                return _Focused && target.Enabled && _CanShowHighlight;
            }


            FocusableActionDetector oldTarget = oldWidget ?? Widget;
            bool didShowHoverHighlight = ShouldShowHoverHighlight(oldTarget);
            bool didShowFocusHighlight = ShouldShowFocusHighlight(oldTarget);
            if (task != null) task();
            bool doShowHoverHighlight = ShouldShowHoverHighlight(Widget);
            bool doShowFocusHighlight = ShouldShowFocusHighlight(Widget);
            if (didShowFocusHighlight != doShowFocusHighlight) Widget.OnShowFocusHighlight?.Call(doShowFocusHighlight);
            if (didShowHoverHighlight != doShowHoverHighlight) Widget.OnShowHoverHighlight?.Call(doShowHoverHighlight);
        }




        public new void DidUpdateWidget(FlutterSDK.Widgets.Actions.FocusableActionDetector oldWidget)
        {
            base.DidUpdateWidget(oldWidget);
            if (Widget.Enabled != oldWidget.Enabled)
            {
                BindingDefaultClass.SchedulerBinding.Instance.AddPostFrameCallback((TimeSpan duration) =>
                {
                    _MayTriggerCallback(oldWidget: oldWidget);
                }
                );
            }

        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            Widget child = new MouseRegion(onEnter: _HandleMouseEnter, onExit: _HandleMouseExit, child: new Focus(focusNode: Widget.FocusNode, autofocus: Widget.Autofocus, canRequestFocus: Widget.Enabled, onFocusChange: _HandleFocusChange, child: Widget.Child));
            if (Widget.Enabled && Widget.Actions != null && Widget.Actions.IsNotEmpty)
            {
                child = new Actions(actions: Widget.Actions, child: child);
            }

            if (Widget.Enabled && Widget.Shortcuts != null && Widget.Shortcuts.IsNotEmpty)
            {
                child = new Shortcuts(shortcuts: Widget.Shortcuts, child: child);
            }

            return child;
        }



    }


    /// <Summary>
    /// An [Action], that, as the name implies, does nothing.
    ///
    /// This action is bound to the [Intent.doNothing] intent inside of
    /// [WidgetsApp.build] so that a [Shortcuts] widget can bind a key to it to
    /// override another shortcut binding defined above it in the hierarchy.
    /// </Summary>
    public class DoNothingAction : FlutterSDK.Widgets.Actions.Action
    {
        /// <Summary>
        /// Const constructor for [DoNothingAction].
        /// </Summary>
        public DoNothingAction()
        : base(Key)
        {

        }
        /// <Summary>
        /// The Key used for the [DoNothingIntent] intent, and registered at the top
        /// level actions in [WidgetsApp.build].
        /// </Summary>
        public virtual FlutterSDK.Foundation.Key.LocalKey Key { get; set; }

        public new void Invoke(FlutterSDK.Widgets.Focusmanager.FocusNode node, FlutterSDK.Widgets.Actions.Intent intent)
        {
        }



    }


    /// <Summary>
    /// An action that invokes the currently focused control.
    ///
    /// This is an abstract class that serves as a base class for actions that
    /// activate a control. By default, is bound to [LogicalKeyboardKey.enter] in
    /// the default keyboard map in [WidgetsApp].
    /// </Summary>
    public class ActivateAction : FlutterSDK.Widgets.Actions.Action
    {
        /// <Summary>
        /// Creates a [ActivateAction] with a fixed [key];
        /// </Summary>
        public ActivateAction()
        : base(Key)
        {

        }
        /// <Summary>
        /// The [LocalKey] that uniquely identifies this action.
        /// </Summary>
        public virtual FlutterSDK.Foundation.Key.LocalKey Key { get; set; }
    }


    /// <Summary>
    /// An action that selects the currently focused control.
    ///
    /// This is an abstract class that serves as a base class for actions that
    /// select something. It is not bound to any key by default.
    /// </Summary>
    public class SelectAction : FlutterSDK.Widgets.Actions.Action
    {
        /// <Summary>
        /// Creates a [SelectAction] with a fixed [key];
        /// </Summary>
        public SelectAction()
        : base(Key)
        {

        }
        /// <Summary>
        /// The [LocalKey] that uniquely identifies this action.
        /// </Summary>
        public virtual FlutterSDK.Foundation.Key.LocalKey Key { get; set; }
    }

}
