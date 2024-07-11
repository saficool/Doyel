import { Routes } from '@angular/router';
import { MainComponent } from './main/main.component';
import { HomeComponent } from './main/apps/home/home.component';
import { KnowledgeGraphComponent } from './main/apps/knowledge-graph/knowledge-graph.component';
import { DocumentAssistantComponent } from './main/apps/document-assistant/document-assistant.component';

export const routes: Routes = [
    {
        path: '',
        component: MainComponent,
        children: [
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent, title: 'Home' },
            { path: 'relation-graph', component: KnowledgeGraphComponent, title: 'Relation Graph' },
            { path: 'document-assistant', component: DocumentAssistantComponent, title: 'Document Assistant' }
        ]
    }
];
