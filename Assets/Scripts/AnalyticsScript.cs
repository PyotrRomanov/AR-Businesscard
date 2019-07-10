using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public static class AnalyticsScript 
{
    public static void FirstDetection(){
        AnalyticsEvent.Custom("first_detection", new Dictionary<string, object>
        {
            {"time_of_day", System.DateTime.Now}
        });
    }

    public static void LostPermanently(){
        AnalyticsEvent.Custom("lost_permanently", new Dictionary<string, object>
        {
            {"time_of_day", System.DateTime.Now}
        });
    }

    public static void OpenedPrism()
    {
        AnalyticsEvent.Custom("opened_prism", new Dictionary<string, object>
        {
            {"time_of_day", System.DateTime.Now}
        });
    }

    public static void ClosedPrism()
    {
        AnalyticsEvent.Custom("closed_prism", new Dictionary<string, object>
        {
            {"time_of_day", System.DateTime.Now}
        });
    }

    public static void OpenedVideo()
    {
        AnalyticsEvent.Custom("opened_video", new Dictionary<string, object>
        {
            {"time_of_day", System.DateTime.Now}
        });
    }

    public static void ClosedVideo()
    {
        AnalyticsEvent.Custom("closed_video", new Dictionary<string, object>
        {
            {"time_of_day", System.DateTime.Now}
        });
    }

    public static void OpenedAnimation()
    {
        AnalyticsEvent.Custom("opened_animation", new Dictionary<string, object>
        {
            {"time_of_day", System.DateTime.Now}
        });
    }

    public static void ClosedAnimation()
    {
        AnalyticsEvent.Custom("closed_animation", new Dictionary<string, object>
        {
            {"time_of_day", System.DateTime.Now}
        });
    }


}
