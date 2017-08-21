const CACHE_NAME = 'app-cache-v1';

const filesToCache = [
    "/index.html",
    "/sw.js",
    "/fonts/fontawesome-webfont.eot",
    "/fonts/glyphicons-halflings-regular.eot",
    "/img/line.png",
    "/img/star-grey.png",
    "/img/star-red.png",
    "/css/styles.css",
    "/polyfills.bundle.js",
    "/vendor.bundle.js",
    "/main.bundle.js",
];

self.addEventListener('install', function (event: any) {
    event.waitUntil(
        caches.open(CACHE_NAME).then(function (cache) {
            console.log('[ServiceWorker] Caching app shell');
            return cache.addAll(filesToCache);
        }).then(() => {
            console.info("finished install")
        })
    );

});

self.addEventListener('fetch', function (event: any) {
    event.respondWith(
        caches.open(CACHE_NAME).then(function (cache) {
            return cache.match(event.request).then(function (response) {
                return response || fetch(event.request).then(function (response) {
                        cache.put(event.request, response.clone());
                        return response;
                    });
            });
        })
    );
});
