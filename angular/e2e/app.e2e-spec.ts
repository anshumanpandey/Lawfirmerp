import { LawFirmERPTemplatePage } from './app.po';

describe('LawFirmERP App', function() {
  let page: LawFirmERPTemplatePage;

  beforeEach(() => {
    page = new LawFirmERPTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
