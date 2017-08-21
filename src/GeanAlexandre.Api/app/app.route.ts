import {RouterModule, Routes} from "@angular/router";
import {AppComponent} from "./app.component";

const appRoutes: Routes = [
    {path: '', redirectTo: 'geanalexandre', pathMatch: 'full'},
    {path: 'geanalexandre', component: AppComponent},
    {path: '**', redirectTo: 'geanalexandre'}
];

export const AppRouteModule = RouterModule.forRoot(
    appRoutes,
    {useHash: true}
);
