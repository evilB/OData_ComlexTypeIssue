describe("TestModel queries", function () {


	it("api/testmodels", function (done) {
		return fetch("api/testmodels").then(function (result) {
			expect(result.ok).toBe(true);
			return result.json();
		}).then(data => {
			expect(data.value.length).toBe(2);
		}).catch(f => {
			fail(f);

		}).then(v => done());

	});

	it("api/testmodels(2)", function (done) {
		fetch("api/testmodels(2)").then(function (result) {
			expect(result.ok).toBe(true);
			return result.json();
		}).then(data => {
			expect(data.Id).toBe(2);
		}).catch(f => {
			fail(f);

		}).then(v => done());

	});

	it("api/testmodels?$select=id,description", function (done) {
		fetch("api/testmodels?$select=id,description").then(function (result) {
			expect(result.ok).toBe(true);
			return result.json();
		}).then(data => {
			expect(data.value.length).toBe(2);
			expect(data.value[0].Id).toBe(1);
			expect(data.value[0].Description.En).toBe("Hello");
		}).catch(f => {
			fail(f);

		}).then(v => done());

	});

	it("api/testmodels?$select=description", function (done) {
		fetch("api/testmodels?$select=description").then(function (result) {
			expect(result.ok).toBe(true);
			return result.json();
		}).then(data => {
			expect(data.value.length).toBe(2);
			expect(data.value[0].Id).toBe(undefined);
			expect(data.value[0].Description.En).toBe("Hello");
		}).catch(f => {
			fail(f);

		}).then(v => done());

	});
	it("api/testmodels?$select=description&$filter=description/fr eq 'Au revoir'", function (done) {
		fetch("api/testmodels?$select=description&$filter=description/fr eq 'Au revoir'").then(function (result) {
			expect(result.ok).toBe(true);
			return result.json();
		}).then(data => {
			expect(data.value.length).toBe(1);
			expect(data.value[0].Description.Fr).toBe("Au revoir");
		}).catch(f => {
			fail(f);

		}).then(v => done());

	});
});