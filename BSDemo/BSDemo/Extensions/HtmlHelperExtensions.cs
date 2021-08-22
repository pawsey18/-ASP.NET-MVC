using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.Web.Mvc.Html;

using System.Web.Mvc;
using BSDemo.Models;

public static class HtmlHelperExtensions
{
    public static MvcHtmlString BuildNextPreviousLinks(
    this HtmlHelper htmlHelper, QueryOptions queryOptions, string actionName)
    {
        var urlHelper = new UrlHelper(htmlHelper.ViewContext.RequestContext);
        return new MvcHtmlString(string.Format(
       "<nav>" +
       " <ul class=\"pager\">" +
       " <li class=\"previous {0}\">{1}</li>" +
       " <li class=\"next {2}\">{3}</li>" +
       " </ul>" +
       "</nav>",
        IsPreviousDisabled(queryOptions),
        BuildPreviousLink(urlHelper, queryOptions, actionName),
        IsNextDisabled(queryOptions),
        BuildNextLink(urlHelper, queryOptions, actionName)
        ));
    }
    private static string IsPreviousDisabled(QueryOptions queryOptions)
    {
        return (queryOptions.CurrentPage == 1)
        ? "disabled" : string.Empty;
    }
    private static string IsNextDisabled(QueryOptions queryOptions)
    {
        return (queryOptions.CurrentPage == queryOptions.TotalPages)
        ? "disabled" : string.Empty;
    }
    private static string BuildPreviousLink(
    UrlHelper urlHelper, QueryOptions queryOptions, string actionName)
    {
        return string.Format(
        "<a href=\"{0}\"><span aria-hidden=\"true\">&larr;</span> Previous</a>",
        urlHelper.Action(actionName, new
        {
            SortOrder = queryOptions.SortOrder,
            SortField = queryOptions.SortField,
            CurrentPage = queryOptions.CurrentPage - 1,
            PageSize = queryOptions.PageSize
        }));
    }
    private static string BuildNextLink(
    UrlHelper urlHelper, QueryOptions queryOptions, string actionName)
    {
        return string.Format(
        "<a href=\"{0}\">Next <span aria-hidden=\"true\">&rarr;</span></a>",
        urlHelper.Action(actionName, new
        {
            SortOrder = queryOptions.SortOrder,
            SortField = queryOptions.SortField,
            CurrentPage = queryOptions.CurrentPage + 1,
            PageSize = queryOptions.PageSize
        }));
    }
    // other functions removed for an abbreviated example
}
