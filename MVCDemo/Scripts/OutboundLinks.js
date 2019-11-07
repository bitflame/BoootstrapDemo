<script type="text/javascript">
    function trackOutboundLink(link, category, action) {
    try {
        _gaq.push(['_trackEvent', category, action]);
    } catch (err) {}
    setTimeout(function() {
        document.location.href = link.href;
    }, 100);
}
</script>