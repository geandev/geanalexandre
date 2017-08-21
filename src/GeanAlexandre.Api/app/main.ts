import {platformBrowserDynamic} from '@angular/platform-browser-dynamic';
const runtime = require('serviceworker-webpack-plugin/lib/runtime');

import {AppModule} from './app.module'

if ('serviceWorker' in navigator)
    runtime.register().then(() => {
        console.info("service worker registred");
    }).catch(() => {
        console.info("service worker not registred");
    });

platformBrowserDynamic().bootstrapModule(AppModule)
    .then(success => console.log(`Bootstrap success`))
    .catch(err => console.error(err));