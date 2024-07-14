import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'Proself',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44388/',
    redirectUri: baseUrl,
    clientId: 'Proself_App',
    responseType: 'code',
    scope: 'offline_access Proself',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44371',
      rootNamespace: 'Proself',
    },
  },
} as Environment;
