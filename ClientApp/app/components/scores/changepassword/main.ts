import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';

import { ChangePasswordModule } from './changepassword.module';

const platform = platformBrowserDynamic();
platform.bootstrapModule(ChangePasswordModule);

